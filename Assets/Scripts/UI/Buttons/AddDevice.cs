using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class AddDevice : MonoBehaviour
{
    private TMP_InputField inputField;
    private Button button;
    private string originalPlaceHolderText;

    private void Start()
    {
        GameObject foundObject = GameObject.Find("InputFieldView");
        inputField = foundObject.GetComponentInChildren<TMP_InputField>();
        originalPlaceHolderText = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;

        button = GetComponent<Button>();
        button.onClick.AddListener(() => OnAddButtonClick());
    }

    public void OnAddButtonClick()
    {
        string inputText = inputField.text;

        if (string.IsNullOrEmpty(inputText)) 
        {
            return;
        }

        Debug.Log("Добавлено устройство: " + inputText);

        inputField.text = string.Empty;
        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = $"Устройство {inputText} добавлено! Данные выведены в консоль";
        StartCoroutine(RestorePlaceholderAfterDelay(2f));
    }

    private IEnumerator RestorePlaceholderAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        inputField.placeholder.GetComponent<TextMeshProUGUI>().text = originalPlaceHolderText;
    }
}
