namespace ConsoleApp1.AdventOfCode2025;

public static class _01Safe
{
    static int currentIndex;
    static int code;
    static string[] lines;
    public static int Code => code;

    static _01Safe()
    {
        currentIndex = 50;
        lines = File.ReadAllLines(@"D:\repos\Stuff\src\ConsoleApp1\AdventOfCode2025\01.txt");

        foreach (var line in lines)
        {
            var amount = int.Parse(line[1..]);
            var left = line[0] == 'L';
            if (left)
                MoveLeft(amount);
            else
                MoveRight(amount);

            Console.WriteLine(currentIndex);

            if (currentIndex == 0)
                code++;
        }
    }

    static void MoveLeft(int x)
    {
        for (int i = 0; i < x; i++)
        {
            currentIndex--;
            if (currentIndex == -1)
                currentIndex = 99;
        }
    }

    static void MoveRight(int x)
    {
        for (int i = 0; i < x; i++)
        {
            currentIndex++;
            if (currentIndex == 100)
                currentIndex = 0;
        }
    }
}
