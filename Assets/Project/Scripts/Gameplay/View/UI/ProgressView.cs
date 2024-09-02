public class ProgressView : TextView<int>
{
    private void OnEnable()
    {
        Progress.Changed += (value) => UpdateText(value, Progress.Target);
    }

    private void Start()
    {
        UpdateText(Progress.Value, Progress.Target);
    }

    private void OnDisable()
    {
        Progress.Changed -= (value) => UpdateText(value, Progress.Target);
    }
}