public class Program
{
    public static void Main(string[] args)
    {
        // Tuples:
        // can be useful when you want to return more than one peince of information
        var tuple = Tuple.Create("Jack", 26);

        // Can use Item1 and Item2 to access values
        Console.WriteLine($"Name: {tuple.Item1} Age: {tuple.Item2}");

        // The max amount of values a tuple can hold is 8
        var largeTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);

        // ValueTuples:
        // can be created in 2 ways
        var valueTuple1 = new ValueTuple<string, int>("Jack", 26);
        var valueTuple2 = ("Sorcha", 20);

        Console.WriteLine($"Value tuple 1: {valueTuple1} and Value tuple 2: {valueTuple2}");

        // Tuples are reference types and valueTuples are value types
    }
}