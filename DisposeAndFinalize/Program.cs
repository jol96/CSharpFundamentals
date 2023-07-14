public class Program
{
    // Dispose() is used to handle unmanaged resources like DB connections, file streams etc.
    // The Common Language Runtime handles managed resources like objects

    public static void Main(string[] args)
    {
        // Approach 1: Call Dispose() manually
        var fileReader = new FileReader("..\\..\\..\\TextFile1.txt");
        fileReader.ReadLines();
        fileReader.Dispose();

        // Approach 2: Dispose() is automatically called with using statemment
        using (var fileReader2 = new FileReader("..\\..\\..\\TextFile1.txt"))
        { 
            fileReader2.ReadLines(); 
        }

        // Approach 3: 
        try
        {
            fileReader.ReadLines();
        }
        finally 
        { 
            fileReader?.Dispose(); 
        }
    }
}

public class FileReader : IDisposable
{
    private StreamReader _stream;
    private readonly string _path;

    public FileReader(string path)
    { 
        _path = path; 
    }

    public string ReadLine()
    {
        _stream = new StreamReader(_path);
        var line = _stream.ReadLine();
        Console.WriteLine($"Line: {line}");
        return line;
    }

    public List<string> ReadLines()
    {
        _stream = new StreamReader(_path);
        var lines = new List<string>();
        string line;
        while ((line = _stream.ReadLine()) != null)
        {
            lines.Add(line);
        }
        foreach (var l in lines)
        {
            Console.WriteLine($"Line: {l}");
        }
        return lines;
    }


    public void Dispose()
    {
        _stream.Dispose();
    }
}