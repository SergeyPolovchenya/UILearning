using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace App.UI
{
    public class AddDeviceViewController : ViewController
    {
        [SerializeField] private Button closeBtn;
        [SerializeField] private Button addDeviceBtn;
        [SerializeField] private Button cancelBtn;
        [SerializeField] private TMP_InputField inputFieldText;

        public override void Init(IWindowStarter starter)
        {
            base.Init(starter);

            closeBtn.onClick.AddListener(Close);
            cancelBtn.onClick.AddListener(Close);
            addDeviceBtn.onClick.AddListener(AddDevice_Clicked);
        }

        private void AddDevice_Clicked()
        {
            string inputText = inputFieldText.text;

            if (string.IsNullOrEmpty(inputText))
            {
                return;
            }

            Debug.Log("Добавлено устройство: " + inputText);
        }
    }
}
