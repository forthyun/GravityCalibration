#ifndef _GRAVITY_CALIBRATION_FORM_FACTORY_H_
#define _GRAVITY_CALIBRATION_FORM_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class GravityCalibrationFormFactory
	: public Tizen::Ui::Scenes::IFormFactory
{
public:
	GravityCalibrationFormFactory(void);
	virtual ~GravityCalibrationFormFactory(void);

	virtual Tizen::Ui::Controls::Form* CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _GRAVITY_CALIBRATION_FORM_FACTORY_H_
