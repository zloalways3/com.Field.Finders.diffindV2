public class BackgroundMusic : Audio<BackgroundMusic>
{
    protected override string SaveKey => nameof(BackgroundMusic);
    protected override bool PlayOnAwake => true;
    protected override bool Loop => true;
}