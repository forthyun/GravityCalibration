#ifndef _GRAVITY_CALIBRATION_MAIN_FORM_H_
#define _GRAVITY_CALIBRATION_MAIN_FORM_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FUix.h>
#include <FGraphics.h>
#include <gl.h>

namespace State
{
	enum Enum {
		Unknown,
		Static,
		Dynamic,
		Collecting,
		Computing,
		Calibrated
	};
}

namespace Action
{
	enum Enum {
		Reset,
		Collect,
		Discard,
		Save
	};
}

using namespace Action;
using namespace State;
using namespace Tizen::Uix::Sensor;

class GravityCalibrationMainForm
	: public Tizen::Ui::Controls::Form
	, public Tizen::Ui::IActionEventListener
	, public Tizen::Ui::Controls::IFormBackEventListener
 	, public Tizen::Ui::Scenes::ISceneEventListener
 	, public Tizen::Uix::Sensor::ISensorEventListener
{
public:
	GravityCalibrationMainForm(void);
	virtual ~GravityCalibrationMainForm(void);
	bool Initialize(void);
	void ResetCalibration(void);
	void StartSensor(void);
	void StopSensor(void);
	State::Enum MovementDetection(void);

private:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
	virtual void OnActionPerformed(const Tizen::Ui::Control& source, int actionId);
	virtual void OnDataReceived(Tizen::Uix::Sensor::SensorType sensorType, Tizen::Uix::Sensor::SensorData& sensorData, result r);
	virtual void OnFormBackRequested(Tizen::Ui::Controls::Form& source);
	virtual void OnSceneActivatedN(const Tizen::Ui::Scenes::SceneId& previousSceneId,
								   const Tizen::Ui::Scenes::SceneId& currentSceneId, Tizen::Base::Collection::IList* pArgs);
	virtual void OnSceneDeactivated(const Tizen::Ui::Scenes::SceneId& currentSceneId,
									const Tizen::Ui::Scenes::SceneId& nextSceneId);

	void Calibration(void);
	void CollectData(Action::Enum action);
	bool isDifferentOrientation(double orientation[3]);
	double Magnitude(double value1, double value2, double value3);
	void MeanGravity(int maxIndex, double result[]);
	void MeanOrientation(int maxIndex, double result[]);
	void PrintProgress(void);

	Tizen::Ui::Controls::Label* __pLabel_RAW_X;
	Tizen::Ui::Controls::Label* __pLabel_RAW_Y;
	Tizen::Ui::Controls::Label* __pLabel_RAW_Z;
	Tizen::Ui::Controls::Label* __pLabel_RAW_M;
	Tizen::Ui::Controls::Label* __pLabel_CAL_X;
	Tizen::Ui::Controls::Label* __pLabel_CAL_Y;
	Tizen::Ui::Controls::Label* __pLabel_CAL_Z;
	Tizen::Ui::Controls::Label* __pLabel_CAL_M;
	Tizen::Ui::Controls::Label* __pLabel_PROGRESS;
	Tizen::Ui::Controls::Label* __pLabel_FEATURE_COUNT;
	Tizen::Ui::Controls::Label* __pLabel_CALIBRATION_RESULT;
	Tizen::Uix::Sensor::SensorManager __sensorMgr;

	const static int MAX_COLLECT = 128;
	const static int MAX_SAMPLES = 50;
	const static int SMALL_WINDOW = 10;
	const static float GRAVITY_THRESHOLD = 0.1f;
	const static float ORIENTATION_THRESHOLD = 0.1 * 360;
	const static int POINT = 6;
	const static int COMBINATION = (POINT * (POINT - 1)) / 2;

	double calibrationResult[6];
	double feature[POINT][6];
	double gravityCollect[MAX_COLLECT][3];
	double gravitySamples[MAX_SAMPLES][3];
	double orientationCollect[MAX_COLLECT][3];
	double orientationSamples[MAX_SAMPLES][3];
	int featureCount;
	int gravitySamplesCount;
	int gravityCollectCount;
	bool isCalibrationSuccess;
	int orientationSamplesCount;
	int orientationCollectCount;
	State::Enum currentState;



protected:

};

#endif	//_GRAVITY_CALIBRATION_MAIN_FORM_H_
