public class ClickSFX : Audio<ClickSFX>
{
    protected override string SaveKey => nameof(ClickSFX);
    protected override bool PlayOnAwake => false;
    protected override bool Loop => false;

    public static void Play()
    {
        StaticInstance.Source.Play();
    }
}