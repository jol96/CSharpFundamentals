using Async;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "C:\\Users\\Jack\\workspace\\C#\\Async\\TextFile.txt";

        var task = FileReader.ReadFileAsync(filePath);

        task.Wait();

        string fileText = task.Result;

        Console.WriteLine(fileText);
    }
}