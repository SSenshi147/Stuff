namespace ConsoleApp1;

public static class FileWatcher
{
    public static void CheckForChanges()
    {
        Console.WriteLine("Hello, World!");

        using var watcher = new FileSystemWatcher(@"C:\Users\MARCI\Documents\test", "*.txt");
        watcher.Changed += Watcher_Changed;
        watcher.EnableRaisingEvents = true;

        while (true)
        {
            watcher.WaitForChanged(WatcherChangeTypes.Changed);
        }
    }

    private static void Watcher_Changed(object sender, FileSystemEventArgs e)
    {
        using var fileStream = File.OpenRead(@"C:\Users\MARCI\Documents\test\asd.txt");
        using var sr = new StreamReader(fileStream);
        int sum = 0;
        while (!sr.EndOfStream)
        {
            if (int.TryParse(sr.ReadLine(), out var add))
                sum += add;
        }
        Console.WriteLine(sum);
    }
}
