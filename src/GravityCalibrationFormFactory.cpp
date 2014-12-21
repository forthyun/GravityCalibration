#include <new>
#include "GravityCalibrationFormFactory.h"
#include "GravityCalibrationMainForm.h"
#include "AppResourceId.h"

using namespace Tizen::Ui::Scenes;


GravityCalibrationFormFactory::GravityCalibrationFormFactory(void)
{
}

GravityCalibrationFormFactory::~GravityCalibrationFormFactory(void)
{
}

Tizen::Ui::Controls::Form*
GravityCalibrationFormFactory::CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId)
{
	SceneManager* pSceneManager = SceneManager::GetInstance();
	AppAssert(pSceneManager);
	Tizen::Ui::Controls::Form* pNewForm = null;

	if (formId == IDL_FORM)
	{
		GravityCalibrationMainForm* pForm = new (std::nothrow) GravityCalibrationMainForm();
		TryReturn(pForm != null, null, "The memory is insufficient.");
		pForm->Initialize();
		pSceneManager->AddSceneEventListener(sceneId, *pForm);
		pNewForm = pForm;
	}
	// TODO: Add your form creation code here

	return pNewForm;
}
