public abstract class VolumeSlider<T> : SliderListener where T : Audio<T>
{
    protected override void Listen(float value)
    {
        Audio<T>.StaticInstance.ChangeVolume(value);
    }
}