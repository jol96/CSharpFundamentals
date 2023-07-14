public class Program
{
    // Deconstruction is a mechanism that allows breaking a tuple
    // or a positional record into individual variables.

    public static (int count, int sum, double average) AnalyseNumbers(IEnumerable<int> numbers)
    {
        var sum = 0;
        var count = 0;
        foreach (var number in numbers)
        {
            sum += number;
            count++;
        }
        var average = (double)sum/ count;
        return (count, sum, average);
    }

    public static void Main(string[] args)
    {
        var numbers = new[] { 1,2,3};
        var (count, sum, average) = AnalyseNumbers(numbers);

        Console.WriteLine($"Count: {count}, Sum: {sum}, Average: {average}");
    }
}