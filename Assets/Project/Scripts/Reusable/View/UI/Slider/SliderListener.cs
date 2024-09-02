using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class SliderListener : UIListener
{
    protected abstract float StartValue { get; }

    protected virtual void Listen(float value) { }

    protected override void Subscribe()
    {
        var slider = GetComponent<Slider>();

        slider.SetValueWithoutNotify(StartValue);

        slider.onValueChanged.AddListener((_) => Listen());
        slider.onValueChanged.AddListener(Listen);
    }
}