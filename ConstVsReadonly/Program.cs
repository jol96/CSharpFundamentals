public class Program
{
    public const int MyConstant = 10; // Compile-time constant 
    public readonly int MyReadOnlyField;

    public Program(int value)
    {
        MyReadOnlyField = value; // Runtime initialization 
    }

    static void Main(string[] args)
    {
        Program program = new(3);
        Console.WriteLine($"MyReadOnlyField: {program.MyReadOnlyField}"); // 3 
        Console.WriteLine($"MyConstant: {MyConstant}"); // 10 
    }

}