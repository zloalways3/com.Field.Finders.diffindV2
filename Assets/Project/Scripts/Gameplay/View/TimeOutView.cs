using UnityEngine;

public class TimeOutView : MonoBehaviour
{
    [SerializeField] private GameObject _win;
    [SerializeField] private GameObject _lose;

    private void Awake()
    {
        Timer.Expired += Show;
    }

    private void Show()
    {
        var completed = Progress.Completed;

        _win.SetActive(completed);
        _lose.SetActive(!completed);
    }

    private void OnDestroy()
    {
        Timer.Expired -= Show;
    }
}