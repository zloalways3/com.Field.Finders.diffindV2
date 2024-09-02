using UnityEngine;

public class SceneLoadButton : ButtonListener
{
    [SerializeField] private string _sceneName;

    protected override void Listen()
    {
        SceneLoad.Load(_sceneName);
    }
}