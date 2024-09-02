public static class Level
{
    public const int LevelCount = 12;
    public const int MinValue = 1;

    public static int Value { get; private set; } = MinValue;

    public static bool TrySetValue(int value)
    {
        if (value > LevelCount) return false;
        if (value < MinValue) return false;

        Value = value;

        return true;
    }

    public static bool TryNextLevel()
    {
        if (Value >= LevelCount) return false;

        Value++;

        return true;
    }
}