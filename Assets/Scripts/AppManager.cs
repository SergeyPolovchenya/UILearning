using App.UI;
using UnityEngine;

namespace App
{
    public class AppManager : MonoBehaviour
    {
        public static ViewController mainView;
        public static ViewController inputFieldView;
        void Start()
        {
            LeanTween.reset();
            LeanTween.init();

            inputFieldView = WindowsManager.Instance.CreateWindow<InputFieldViewController>(new InputFieldViewStarter());
            mainView = WindowsManager.Instance.CreateWindow<MainViewController>(new MainViewStarter());
            mainView.Show();
        }

        private void OnDestroy()
        {

        }
    }
}