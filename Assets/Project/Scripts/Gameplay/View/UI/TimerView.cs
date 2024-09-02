public class TimerView : TextView<int>
{
    private void OnEnable()
    {
        Timer.Updated += UpdateText;
        UpdateText(Timer.Value);
    }

    private void OnDisable()
    {
        Timer.Updated -= UpdateText;
    }
}