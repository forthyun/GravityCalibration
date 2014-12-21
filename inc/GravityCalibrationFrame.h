#ifndef _GRAVITY_CALIBRATION_FRAME_H_
#define _GRAVITY_CALIBRATION_FRAME_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class GravityCalibrationFrame
	: public Tizen::Ui::Controls::Frame
{
public:
	GravityCalibrationFrame(void);
	virtual ~GravityCalibrationFrame(void);

private:
	virtual result OnInitializing(void);
	virtual result OnTerminating(void);
};

#endif	//_GRAVITY_CALIBRATION_FRAME_H_
