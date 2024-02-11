using App;
using UnityEngine;
using UnityEngine.UI;

public class Cancel : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnButtonClick());
    }
    public void OnButtonClick()
    {
        AppManager.inputFieldView.Close();
    }
}
