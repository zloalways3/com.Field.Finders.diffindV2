using UnityEngine;

public class ExitButton : ButtonListener
{
    protected override void Listen()
    {
        Application.Quit();
    }
}