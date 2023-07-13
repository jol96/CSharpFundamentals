public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<int> numbers = new int[] { 1, 11, 3, 4, 5 };
        var number = 12;

        // Using standard methods
        isLarger(numbers);
        isEven(numbers);


        // Using Functions
        Func<int, bool> predicate1 = isGreaterThanTen;
        Func<int, bool> predicate2 = isEven;

        Console.WriteLine("Functions: IsAnyLargerThan10 " + isAny(number, predicate1));
        Console.WriteLine("Functions: IsEven " + isAny(number, predicate2));

        // Using Lambdas
        Console.WriteLine("Lambdas: IsAnyLargerThan10 " + isAny(number, n => n > 10));
        Console.WriteLine("Lambdas: IsEven " + isAny(number, n => n % 2 == 0));
    }

    #region Using standard methods
    static bool isLarger(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            if (number > 10)
            {
                Console.WriteLine($"{number} is larger than 10");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} is less than 10");
            }
        }

        return false;
    }

    static bool isEven(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }
        }

        return false;
    }
    #endregion


    #region Using functions
    static bool isAny(int number, Func<int, bool> predicate)
    {
        if (predicate(number))
        {
            return true;
        }
        return false;
    }

    static bool isGreaterThanTen(int number)
    {
        if (number > 10)
        {
            return true;
        }
        return false;
    }

    static bool isEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        return false;
    }
    #endregion

}