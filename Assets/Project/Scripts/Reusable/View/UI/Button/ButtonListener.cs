using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonListener : UIListener
{
    protected Button Button { get; private set; }

    protected override void Subscribe()
    {
        Button = GetComponent<Button>();

        Button.onClick.AddListener(Listen);
    }
}