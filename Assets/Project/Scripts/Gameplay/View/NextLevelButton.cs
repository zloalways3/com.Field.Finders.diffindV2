public class NextLevelButton : ButtonListener
{
    protected override void Listen()
    {
        if (!Level.TryNextLevel()) return;

        SceneLoad.Restart();
    }
}
