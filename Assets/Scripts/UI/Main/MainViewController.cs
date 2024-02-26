using UnityEngine;
using UnityEngine.UI;
namespace App.UI
{
    public class MainViewController : ViewController
    {
        [SerializeField] private Button openAddDeviceBtn;
        [SerializeField] private Button closeApplicationBtn;
        private ViewController addDeviceView;

        public override void Init(IWindowStarter starter)
        {
            base.Init(starter);
            openAddDeviceBtn.onClick.AddListener(InitAddDeviceView);
            closeApplicationBtn.onClick.AddListener(ExitApplication);
        }

        private void SetMainViewInvisible(ViewController controller)
        {    
            DisableInteractables();
            canvasGroup.alpha = 0.95f;
        }

        private void SetMainViewVisible(ViewController controller)
        {                  
            EnableColliders();
            canvasGroup.alpha = 1f;
        }

        private void InitAddDeviceView()
        {
            addDeviceView = WindowsManager.Instance.CreateWindow<AddDeviceViewController>(new AddDeviceViewStarter());
            addDeviceView.OnShowWindow += SetMainViewInvisible;
            addDeviceView.OnHideWindow += SetMainViewVisible;
            addDeviceView.Show();
        }

        private void ExitApplication()
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}