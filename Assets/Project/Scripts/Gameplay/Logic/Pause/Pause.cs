using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool IsPaused { get; private set; }

    public void SetPause()
    {
        IsPaused = true;
    }

    public void Resume()
    {
        IsPaused = false;
    }
}