public class ClickSFXVolumeSlider : VolumeSlider<ClickSFX>
{
    protected override float StartValue => ClickSFX.StaticInstance.Volume;
}