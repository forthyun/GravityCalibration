/*
	GravityCalibration
	Copyright (C) 2014, Hyunchoong Kim
	hyunchoong.kim@yonsei.ac.kr

	This work is free software; you can redistribute it and/or modify it
	under the terms of the GNU Lesser General Public License as published by
	the Free Software Foundation; either version 2.1 of the License, or (at
	your option) any later version.

	This work is distributed in the hope that it will be useful, but
	without any warranty; without even the implied warranty of
	merchantability or fitness for a particular purpose.
	See the GNU Lesser General Public License for more details.

	You should have received a copy of the GNU Lesser General Public License
	along with this library; if not, write to the Free Software Foundation,
	Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

#include <FApp.h>
#include <FIo.h>
#include <FSystem.h>
#include "GravityCalibrationMainForm.h"
#include "AppResourceId.h"
using namespace Tizen::Base;
using namespace Tizen::App;
using namespace Tizen::Ui;
using namespace Tizen::Ui::Controls;
using namespace Tizen::Ui::Scenes;
using namespace Tizen::Uix::Sensor;

using namespace std;
#include "qr_solve.hpp"
#include "test_ls.hpp"
#include "r8lib.hpp"


GravityCalibrationMainForm::GravityCalibrationMainForm(void) : __sensorMgr()
{
}

GravityCalibrationMainForm::~GravityCalibrationMainForm(void)
{
}

//****************************************************************************80
void
GravityCalibrationMainForm::Calibration(void)
{
//****************************************************************************80
//
//  Purpose:
//
//		Static Calibration of accelerometer on the tizen reference phone
//
//  Discussion:
//
//		This code is an modified implementation of MARINOV's et al. paper.
//		This code uses several points for calibration; at least 6 points.
//  Licensing:
//
//    This code is distributed under the GNU LGPL license.
//
//  Modified:
//
//    19 December 2014
//
//  Author:
//
//		Hyunchoong Kim
//
//  Reference:
//
//	MARINOV, Marin, and Zhivo PETROV,
//	AN APPROACH FOR STATIC CALIBRATION OF ACCELEROMETER MMA8451Q,
//	Scientific Research & Education in the Air Force - AFASES;2014, Vol. 1, p189
//
	int i, j, k;
	int flag;
	double mag2[POINT];
	//double matrixH[COMBINATION][POINT], matrixA[COMBINATION];
	//double matrixX[POINT];
	double *matrixH, *matrixA, *matrixX;

	matrixH = new double[COMBINATION * 6];
	matrixA = new double[COMBINATION];
	matrixX = new double[6];
	for(i = 0; i < POINT; i++) {
		mag2[i] = feature[i][0] * feature[i][0] +
				  feature[i][1] * feature[i][1] +
		          feature[i][2] * feature[i][2] ;
	}
	k = 0;
	for(i = 0; i < POINT-1; i++) {
		for(j = i+1; j < POINT; j++) {
			matrixH[ k ] = feature[i][0] - feature[j][0];
			matrixH[ k + COMBINATION] = feature[i][1] - feature[j][1];
			matrixH[ k + COMBINATION * 2] = feature[i][2] - feature[j][2];
			matrixH[ k + COMBINATION * 3] = feature[j][0] * feature[j][0] - feature[i][0] * feature[i][0];
			matrixH[ k + COMBINATION * 4] = feature[j][1] * feature[j][1] - feature[i][1] * feature[i][1];
			matrixH[ k + COMBINATION * 5] = feature[j][2] * feature[j][2] - feature[i][2] * feature[i][2];
			matrixA[k] = (mag2[i]  - mag2[j]) * 0.5;
			k++;
		}
	}
	//matrixX = normal_solve (COMBINATION, 6, matrixH, matrixA, flag);
	matrixX = qr_solve (COMBINATION, 6, matrixH, matrixA);
	//matrixX = svd_solve (COMBINATION, 6, matrixH, matrixA);
	AppLog("X: %f %f %f %f %f %f", matrixX[0], matrixX[1], matrixX[2], matrixX[3], matrixX[4], matrixX[5]);

	calibrationResult[0] = (sqrt(1.0 / (1.0 + matrixX[3]) ));
	calibrationResult[1] = (sqrt(1.0 / (1.0 + matrixX[4]) ));
	calibrationResult[2] = (sqrt(1.0 / (1.0 + matrixX[5]) ));
	calibrationResult[3] = (matrixX[0] / (1.0 + matrixX[3]));
	calibrationResult[4] = (matrixX[1] / (1.0 + matrixX[4]));
	calibrationResult[5] = (matrixX[2] / (1.0 + matrixX[5]));
	isCalibrationSuccess = true;

	AppLog("CAL: %f %f %f %f %f %f",calibrationResult[0], calibrationResult[1], calibrationResult[2], calibrationResult[3], calibrationResult[4], calibrationResult[5]);

}

bool
GravityCalibrationMainForm::Initialize(void)
{
	result r = Construct(IDL_FORM);
	TryReturn(r == E_SUCCESS, false, "Failed to construct form");

	return true;
}

result
GravityCalibrationMainForm::OnInitializing(void)
{
	result r = E_SUCCESS;

	// TODO: Add your initialization code here
	__sensorMgr.Construct();
	if (!__sensorMgr.IsAvailable(SENSOR_TYPE_GRAVITY)|| !__sensorMgr.IsAvailable(SENSOR_TYPE_DEVICE_ORIENTATION)) {
		return E_FAILURE;
	}
	__pLabel_RAW_X = static_cast< Label* >(GetControl(L"IDC_LABEL_RAW_X"));
	__pLabel_RAW_Y = static_cast< Label* >(GetControl(L"IDC_LABEL_RAW_Y"));
	__pLabel_RAW_Z = static_cast< Label* >(GetControl(L"IDC_LABEL_RAW_Z"));
	__pLabel_RAW_M = static_cast< Label* >(GetControl(L"IDC_LABEL_RAW_M"));
	__pLabel_CAL_X = static_cast< Label* >(GetControl(L"IDC_LABEL_CAL_X"));
	__pLabel_CAL_Y = static_cast< Label* >(GetControl(L"IDC_LABEL_CAL_Y"));
	__pLabel_CAL_Z = static_cast< Label* >(GetControl(L"IDC_LABEL_CAL_Z"));
	__pLabel_CAL_M = static_cast< Label* >(GetControl(L"IDC_LABEL_CAL_M"));
	__pLabel_PROGRESS = static_cast< Label* >(GetControl(L"IDC_LABEL_PROGRESS"));
	__pLabel_FEATURE_COUNT = static_cast< Label* >(GetControl(L"IDC_LABEL_FEATURE_COUNT"));
	__pLabel_CALIBRATION_RESULT = static_cast< Label* >(GetControl(L"IDC_LABEL_CALIBRATION_RESULT"));
	ResetCalibration();

	// Setup back event listener
	SetFormBackEventListener(this);

	// Get a button via resource ID
	Button* pButton_cal = static_cast<Button*>(GetControl(IDC_BUTTON_CAL));  
	if(pButton_cal)
	{
		pButton_cal->SetActionId(101);
		pButton_cal->AddActionEventListener(*this);
	}
	Button* pButton_reset = static_cast<Button*>(GetControl(IDC_BUTTON_RESET));  
	if(pButton_reset)
	{
		pButton_reset->SetActionId(102);
		pButton_reset->AddActionEventListener(*this);
	}
	return r;
}

result
GravityCalibrationMainForm::OnTerminating(void)
{
	result r = E_SUCCESS;
	// TODO: Add your termination code here
	StopSensor();
	return r;
}

void
GravityCalibrationMainForm::OnActionPerformed(const Tizen::Ui::Control& source, int actionId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);

	switch(actionId)
	{
	case 101:
		if(featureCount >= POINT) {
			currentState = State::Computing;
			Calibration();
			currentState = State::Calibrated;
		}
		break;
	case 102:
		ResetCalibration();
		break;
	default:
		break;
	}
}

void
GravityCalibrationMainForm::OnDataReceived(SensorType sensorType, SensorData& sensorData, result r)
{
	String strM, strX, strY, strZ;
	String strFeatureCount, strFeatureCountMax;
	String strCalM, strCalX, strCalY, strCalZ;
	double x,y,z,magnitude;
	State::Enum checkedState;

	strFeatureCount.Append(featureCount);
	strFeatureCountMax.Append(POINT);
	__pLabel_FEATURE_COUNT->SetText(strFeatureCount + "/" +
									strFeatureCountMax);
	PrintProgress();

	if(sensorType == SENSOR_TYPE_GRAVITY) {
		double orientation[3];
		GravitySensorData& data = static_cast<GravitySensorData&>(sensorData);
		//AppLog("GravitySensorData  x = %5.4f , y = %5.4f,  z = %5.4f ", data.x,data.y,data.z);

		x = data.x;
		y = data.y;
		z = data.z;
		magnitude = Magnitude(x, y, z);
		strX.Append(x);
		strY.Append(y);
		strZ.Append(z);
		strM.Append(magnitude);
		__pLabel_RAW_X->SetText(strX + " ");
		__pLabel_RAW_Y->SetText(strY + " ");
		__pLabel_RAW_Z->SetText(strZ + " ");
		__pLabel_RAW_M->SetText(strM + " ");

		if(isCalibrationSuccess) {
			double calX, calY, calZ, calMagnitude;
			calX = (x - calibrationResult[3]) / calibrationResult[0];
			calY = (y - calibrationResult[4]) / calibrationResult[1];
			calZ = (z - calibrationResult[5]) / calibrationResult[2];

			calMagnitude = Magnitude(calX, calY, calZ);
			strCalX.Append(calX);
			strCalY.Append(calY);
			strCalZ.Append(calZ);
			strCalM.Append(calMagnitude);
			__pLabel_CAL_X->SetText(strCalX + " ");
			__pLabel_CAL_Y->SetText(strCalY + " ");
			__pLabel_CAL_Z->SetText(strCalZ + " ");
			__pLabel_CAL_M->SetText(strCalM + " ");
		}

		gravitySamples[gravitySamplesCount][0] = x;
		gravitySamples[gravitySamplesCount][1] = y;
		gravitySamples[gravitySamplesCount][2] = z;
		gravitySamplesCount++;

		if(orientationSamplesCount == 0) return;

		checkedState = MovementDetection();

		switch(currentState) {
		case State::Dynamic:
			if(checkedState == State::Static) {
				currentState = State::Static;
			}
			break;
		case State::Unknown:
		case State::Static:
			if(checkedState == State::Dynamic) {
				currentState = State::Dynamic;
				CollectData(Action::Discard);
			} else {
				//
				orientation[0] = 0;
				orientation[1] = 0;
				orientation[2] = 0;
				for(int i = 0; i < SMALL_WINDOW; i++) {
					for(int j = 0; j < 3; j++) {
						if(i >= orientationSamplesCount) {
							orientation[j] += orientationSamples[0][j];
						} else {
							orientation[j] += orientationSamples[orientationSamplesCount - i - 1][j];
						}
					}
				}
				for(int j = 0; j < SMALL_WINDOW; j++) {
					orientation[j] /= SMALL_WINDOW;
				}
				if(isDifferentOrientation(orientation)) {
					//AppLog("Device Orientation : %.3f, %.3f, %.3f  ", orientation[0], orientation[1], orientation[2]);
					if(featureCount < POINT) {
						currentState = State::Collecting;
						CollectData(Action::Reset);
					}
				} else {

				}
			}

			break;
		case State::Collecting:
			if(checkedState == State::Dynamic) {
				CollectData(Action::Discard);
				currentState = State::Dynamic;
			} else {
				CollectData(Action::Collect);
				if(gravityCollectCount >= MAX_COLLECT) {
					CollectData(Action::Save);
					currentState = State::Static;
				}
			}
			break;

		default:
			break;
		}


	}
	else if(sensorType == SENSOR_TYPE_DEVICE_ORIENTATION){
		DeviceOrientationSensorData& data = static_cast<DeviceOrientationSensorData&>(sensorData);
		//AppLog("DeviceOrientationSensorData   x = %5.4f , y = %5.4f,  z = %5.4f ", data.yaw,data.roll,data.pitch);
		x = data.yaw;
		y = data.roll;
		z = data.pitch;
		orientationSamples[orientationSamplesCount][0] = x;
		orientationSamples[orientationSamplesCount][1] = y;
		orientationSamples[orientationSamplesCount][2] = z;
		orientationSamplesCount++;
	}

	Invalidate(true);
}

void
GravityCalibrationMainForm::OnFormBackRequested(Tizen::Ui::Controls::Form& source)
{
	UiApp* pApp = UiApp::GetInstance();
	AppAssert(pApp);
	pApp->Terminate();
}

void
GravityCalibrationMainForm::OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId,
										  const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs)
{
	// TODO: Activate your scene here.
	StartSensor();
}

void
GravityCalibrationMainForm::OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
										   const Tizen::Ui::Scenes::SceneId& nextSceneId)
{
	// TODO: Deactivate your scene here.
	StopSensor();
}



//



void
GravityCalibrationMainForm::CollectData(Action::Enum action) {
	double gravityMean[3];
	double orientationMean[3];

	switch(action) {

	case Action::Discard:
	case Action::Reset:
		gravityCollectCount = 0;
		orientationCollectCount = 0;
		break;
	case Action::Collect:
		for(int j = 0; j < 3; j++) {
			gravityCollect[gravityCollectCount][j] =
				gravitySamples[gravitySamplesCount-1][j];
			orientationCollect[orientationCollectCount][j] =
				orientationSamples[orientationSamplesCount-1][j];
		}
		gravityCollectCount++;
		orientationCollectCount++;
		break;
	case Action::Save:
		MeanGravity(gravityCollectCount, gravityMean);
		MeanOrientation(orientationCollectCount, orientationMean);
		for(int j = 0; j < 3; j++) {
			feature[featureCount][j] = gravityMean[j];
			feature[featureCount][j+3] = orientationMean[j];
		}
		featureCount++;
		gravityCollectCount = 0;
		orientationCollectCount = 0;
		break;

	default:
		break;
	}
}

bool
GravityCalibrationMainForm::isDifferentOrientation(double orientation[3]){
	int i, j;
	double difference[3];
	double magnitude;

	if(featureCount == 0) {
		return true;
	}

	for(i = 0; i < featureCount; i++ ) {
		for(j = 0; j < 3; j++) {
			difference[j] = orientation[j] - feature[i][j + 3];
		}
		magnitude = Magnitude(difference[0], difference[1], difference[2]);
		if(magnitude < ORIENTATION_THRESHOLD) {
			return false;
		}
	}
	return true;
}

double
GravityCalibrationMainForm::Magnitude(double value1, double value2, double value3){
	return sqrt( (value1 * value1) + (value2 * value2) + (value3 * value3));
}

void
GravityCalibrationMainForm::MeanGravity(int maxIndex, double result[]) {
	for(int j = 0; j < 3; j++) {
		result[j] = 0;
	}
	for(int i = 0; i < maxIndex; i++ ) {
		for(int j = 0; j < 3; j++) {
			result[j] += gravityCollect[i][j];
		}
	}
	for(int j = 0; j < 3; j++) {
		result[j] /= maxIndex;
	}
}

void
GravityCalibrationMainForm::MeanOrientation(int maxIndex, double result[]) {
	for(int j = 0; j < 3; j++) {
		result[j] = 0;
	}
	for(int i = 0; i < maxIndex; i++ ) {
		for(int j = 0; j < 3; j++) {
			result[j] += orientationCollect[i][j];
		}
	}
	for(int j = 0; j < 3; j++) {
		result[j] /= maxIndex;
	}
}

State::Enum
GravityCalibrationMainForm::MovementDetection()
{
	int i, j;
	double gravityMean = 0.0f;
	double gravityStd = 0.0f;
	double orientationMean = 0.0f;
	double orientationStd = 0.0f;
	double magnitude;

	for(i = 0; i < SMALL_WINDOW; i++){
		if(i >= gravitySamplesCount ) {
			magnitude = Magnitude(gravitySamples[0][0],
								  gravitySamples[0][1],
								  gravitySamples[0][2]);
			gravityMean += magnitude;
			gravityStd += magnitude * magnitude;
		} else {
			magnitude = Magnitude(gravitySamples[gravitySamplesCount - i - 1][0],
								  gravitySamples[gravitySamplesCount - i - 1][1],
								  gravitySamples[gravitySamplesCount - i - 1][2]);
			gravityMean += magnitude;
			gravityStd += magnitude * magnitude;
		}
	}

	for(i = 0; i < SMALL_WINDOW; i++){
		if(i >= orientationSamplesCount ) {
			magnitude = Magnitude(orientationSamples[0][0],
								  orientationSamples[0][1],
								  orientationSamples[0][2]);

			orientationMean += magnitude;
			orientationStd += magnitude * magnitude;
		} else {
			magnitude = Magnitude(
						orientationSamples[orientationSamplesCount - i - 1][0],
						orientationSamples[orientationSamplesCount - i - 1][1],
						orientationSamples[orientationSamplesCount - i - 1][2]);
			orientationMean += magnitude;
			orientationStd += magnitude * magnitude;
		}
	}

	if( gravitySamplesCount >= MAX_SAMPLES) {
		j = int(MAX_SAMPLES / 2);
		for(i = 0; i < j; i++) {
			gravitySamples[i][0] = gravitySamples[i + j][0];
			gravitySamples[i][1] = gravitySamples[i + j][1];
			gravitySamples[i][2] = gravitySamples[i + j][2];
		}
		gravitySamplesCount = j;
	}

	if( orientationSamplesCount >= MAX_SAMPLES) {
		j = int(MAX_SAMPLES / 2);
		for(i = 0; i < j; i++) {
			orientationSamples[i][0] = orientationSamples[i + j][0];
			orientationSamples[i][1] = orientationSamples[i + j][1];
			orientationSamples[i][2] = orientationSamples[i + j][2];
		}
		orientationSamplesCount = j;
	}

	gravityMean /= SMALL_WINDOW;
	gravityStd /= SMALL_WINDOW;
	gravityStd -= gravityMean * gravityMean;
	orientationMean /= SMALL_WINDOW;
	orientationStd /= SMALL_WINDOW;
	orientationStd -= orientationMean * orientationMean;

	if(gravityStd > GRAVITY_THRESHOLD ||
	   orientationStd > ORIENTATION_THRESHOLD) {
		return State::Dynamic;
	} else if(gravityStd < GRAVITY_THRESHOLD &&
		   orientationStd < ORIENTATION_THRESHOLD) {
		return State::Static;
	} else {
		return State::Unknown;
	}

}
void
GravityCalibrationMainForm::PrintProgress(void) {
	String strProgress;
	String strCalibration;
	strProgress = L"";
	switch(currentState) {
	case State::Unknown:
		strProgress = L"...";
		break;
	case State::Static:
		if(featureCount < POINT) {
			strProgress = L"Set device to another orientation.";
		} else {
			strProgress = L"Press Calibrate Button.";
		}
		break;
	case State::Dynamic:
		strProgress = L"Stop Device for collecting data \n(Or bad orientation).";

		break;
	case State::Collecting:
		strProgress = L"Collecting data from this orientation...";
		break;
	case State::Computing:
		strProgress = L"Calibrating...";
		break;
	case State::Calibrated:
		strProgress = L"Calibration is completed.\n";
		char buffer[1024];
		sprintf(buffer,"Sx: %.6lf Sy: %.6lf  Sz: %.6lf\n Bx: %.6lf By: %.6lf  Bz: %.6lf",
				calibrationResult[0], calibrationResult[1], calibrationResult[2],
				calibrationResult[3], calibrationResult[4], calibrationResult[5]);
		strCalibration = buffer;
		__pLabel_CALIBRATION_RESULT->SetText(strCalibration);
		break;
	default:
		break;
	}
	__pLabel_PROGRESS->SetText(strProgress);
}

void
GravityCalibrationMainForm::ResetCalibration(void)
{
	featureCount = 0;
	gravityCollectCount = 0;
	gravitySamplesCount = 0;
	isCalibrationSuccess = false;
	orientationCollectCount = 0;
	orientationSamplesCount = 0;
	currentState = State::Unknown;
	__pLabel_CAL_X->SetText(L"N/A");
	__pLabel_CAL_Y->SetText(L"N/A");
	__pLabel_CAL_Z->SetText(L"N/A");
	__pLabel_CAL_M->SetText(L"N/A");
	__pLabel_CALIBRATION_RESULT->SetText(L"Calibration Constants will be shown here after calibration.");
	for(int i = 0; i < 6; i ++) {
		calibrationResult[i] = 0.0;
	}
}



void
GravityCalibrationMainForm::StartSensor(void)
{
	long interval = 0L;

	AppLog("Activating ...");

	__sensorMgr.GetMinInterval(SENSOR_TYPE_GRAVITY, interval);

	if (interval < 5)
	{
		interval = 5;
	}
	__sensorMgr.AddSensorListener(*this, SENSOR_TYPE_GRAVITY, interval, true);

	__sensorMgr.GetMinInterval(SENSOR_TYPE_DEVICE_ORIENTATION, interval);
	if (interval < 5)
	{
		interval = 5;
	}
	__sensorMgr.AddSensorListener(*this, SENSOR_TYPE_DEVICE_ORIENTATION, interval, true);
}

void
GravityCalibrationMainForm::StopSensor(void)
{
	__sensorMgr.RemoveSensorListener(*this);
}


