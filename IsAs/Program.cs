using System.Runtime.InteropServices.Marshalling;

public class Program
{
    public static void Main(string[] args)
    {
        // Is:
        // Checks if an object is a given type and returns true
        object name = "Jack";
        bool isString = name is string;
        Console.WriteLine($"Is name a string: {isString}");

        // As:
        // Casts an object to a given type
        object age = "12";
        string stringAge = age as string;
        Console.WriteLine($"stringAge: {stringAge} ");

        // Ff casting with "as" keyword fails, the result would be null.
        // This is crucial as exceptions will not be thrown
        // This means that only data types that support nullable values can be cast with the "as" keyword
    }
}