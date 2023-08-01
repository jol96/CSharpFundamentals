public class Program
{
    // Ref example
    public static void RefExample(ref int id)
    {
        id += 1;
    }

    // Out Example
    public static void OutExample(out int id)
    {
        id = 20;
    }

    public static void Main(string[] args)
    {
        // Ref example
        int i = 1;
        Console.WriteLine("Previous value of integer i:" + i.ToString());
        RefExample(ref i);
        Console.WriteLine("Current value of integer i:" + i.ToString());

        // Out Example
        int k = 15;
        Console.WriteLine("Previous value of integer k:" + k.ToString());
        OutExample(out k);
        Console.WriteLine("Current value of integer k:" + k.ToString());
    }
}