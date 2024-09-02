public class BackgroundMusicVolumeSlider : VolumeSlider<BackgroundMusic>
{
    protected override float StartValue => BackgroundMusic.StaticInstance.Volume;
}