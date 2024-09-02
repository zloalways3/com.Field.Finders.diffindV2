using UnityEngine.SceneManagement;

public static class SceneLoad
{
    public static void Restart()
    {
        var name = SceneManager.GetActiveScene().name;
        Load(name);
    }

    public static void Load(string name)
    {
        SceneManager.LoadScene(name);
    }
}