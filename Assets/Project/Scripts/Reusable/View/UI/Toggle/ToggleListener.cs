using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public abstract class ToggleListener : UIListener
{
    protected Toggle Toggle { get; private set; }

    protected virtual void HandleValueChanged(bool value) { }
    protected virtual void HandleEnabled() { }
    protected virtual void HandleDisabled() { }
    protected virtual void HandleSubscribed() { }

    protected override void Subscribe()
    {
        Toggle = GetComponent<Toggle>();

        Toggle.onValueChanged.AddListener((_) => Listen());
        Toggle.onValueChanged.AddListener(HandleValueChanged);
        Toggle.onValueChanged.AddListener(NotifyValueChanged);

        HandleSubscribed();
    }

    private void NotifyValueChanged(bool value)
    {
        if (value) HandleEnabled();
        else HandleDisabled();
    }
}