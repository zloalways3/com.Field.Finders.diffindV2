using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public abstract class Audio<T> : MonoBehaviour where T : Audio<T>
{
    private const float DefaultVolume = 0.5f;

    public static T StaticInstance { get; private set; }

    protected abstract string SaveKey { get; }
    protected abstract bool PlayOnAwake { get; }
    protected abstract bool Loop { get; }

    protected AudioSource Source { get; private set; }

    public float Volume => Source.volume;

    private void Awake()
    {
        Source = GetComponent<AudioSource>();
        Source.playOnAwake = PlayOnAwake;
        Source.loop = Loop;

        ChangeVolume(PlayerPrefs.GetFloat(SaveKey, DefaultVolume));

        StaticInstance = FindObjectOfType<T>();
    }

    public void ChangeVolume(float value)
    {
        Source.volume = value;
        SaveState();
    }

    private void SaveState()
    {
        PlayerPrefs.SetFloat(SaveKey, Source.volume);
    }
}