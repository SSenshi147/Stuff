namespace ConsoleApp1;

public static class FileCreate
{
    public static void Do()
    {
        const string path = "out.txt";
        if (!File.Exists(path))
        {
            // add the using here, otherwise the stream returned by the Create method will block operations
            using var _ = File.Create(path);
        }

        File.WriteAllText(path, "test");
        var content = File.ReadAllText(path);

        Console.WriteLine(content);
    }
}
