#ifndef _GRAVITY_CALIBRATION_PANEL_FACTORY_H_
#define _GRAVITY_CALIBRATION_PANEL_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class GravityCalibrationPanelFactory
	: public Tizen::Ui::Scenes::IPanelFactory
{
public:
	GravityCalibrationPanelFactory(void);
	virtual ~GravityCalibrationPanelFactory(void);

	virtual Tizen::Ui::Controls::Panel* CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _GRAVITY_CALIBRATION_PANEL_FACTORY_H_
