using UnityEngine;

public class AutoSceneLoad : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    private void Start()
    {
        SceneLoad.Load(_sceneName);
    }
}