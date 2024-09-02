using TMPro;
using UnityEngine;

public class LoadLevelButton : ButtonListener
{
    private const string SceneName = "Gameplay";

    [Range(Level.MinValue, Level.LevelCount)]
    [SerializeField] private int _level = Level.MinValue;

#if UNITY_EDITOR
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private string _format;
#endif
    protected override void Listen()
    {
        if (!Level.TrySetValue(_level)) return;
        SceneLoad.Load(SceneName);
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (_text == null) return;
        _text.text = string.Format(_format, _level);
    }
#endif
}