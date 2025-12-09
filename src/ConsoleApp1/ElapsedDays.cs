namespace ConsoleApp1;

/// <summary>
/// I have no idea what was the point of this.
/// </summary>
public static class ElapsedDays
{
    public static void Main(DateTime end, DateTime begin)
    {
        Console.WriteLine((end - begin).Days);
    }
}
