using TMPro;
using UnityEngine;

public abstract class TextView<T> : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textComponent;
    [SerializeField] private string _format = "{0}";

    protected virtual T DefaultValue => default;

    protected void UpdateText(T value)
    {
        _textComponent.text = string.Format(_format, value);
    }

    protected void UpdateText(T value1, T value2)
    {
        _textComponent.text = string.Format(_format, value1, value2);
    }

    protected void UpdateText(T value1, T value2, T value3)
    {
        _textComponent.text = string.Format(_format, value1, value2, value3);
    }
}