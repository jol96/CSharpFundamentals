public class Program
{
    delegate string ProcessString(string input);

    static string TrimTo5Letters(string input)
    {
        return input.Substring(0, 5);
    }

    static string ToUpper(string input)
    {
        return input.ToUpper();
    }

    delegate void Print(string input);

    delegate TReturn Func<TInput1, TInput2, TReturn>(TInput1 input1,  TInput2 input2);

    Func<string, string, int> sumLength = (text1, text2) => text1.Length + text2.Length;
    Func<string, string, int> sumLength2 = SumLengths;

    static int SumLengths(string text1, string text2)
    {
        return text1.Length + text2.Length;
    }

    public static void Main(string[] args)
    {
        ProcessString processString1 = TrimTo5Letters;
        ProcessString processString2 = ToUpper;

        Console.WriteLine(processString1("what is the crack sir"));

        Print print1 = text => Console.WriteLine(text.Substring(0, 5));
        Print print2 = text => Console.WriteLine(text.ToUpper());
        Print print3 = print1 + print2;
        print3("crocodile");


    }

    
}