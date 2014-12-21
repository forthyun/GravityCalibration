#include "GravityCalibrationPanelFactory.h"

using namespace Tizen::Ui::Scenes;


GravityCalibrationPanelFactory::GravityCalibrationPanelFactory(void)
{
}

GravityCalibrationPanelFactory::~GravityCalibrationPanelFactory(void)
{
}

Tizen::Ui::Controls::Panel*
GravityCalibrationPanelFactory::CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Panel* pNewPanel = null;

	// TODO: Add your panel creation code here
	return pNewPanel;
}
