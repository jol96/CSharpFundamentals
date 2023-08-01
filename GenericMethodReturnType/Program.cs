public class Program
{
    public static void Main(string[] args)
    {
        // create an instance with data type string 
        Movie<string> movieName = new Movie<string>();
        Console.WriteLine("Generics Method returns: " + movieName.displayData("Inception"));

        // create an instance with data type int  
        Movie<int> movieRating = new Movie<int>();
        Console.WriteLine("Generics Method returns: " + movieRating.displayData(9));
    }
}

public class Movie<T>
{
    // define a generic method that returns type t value
    public T displayData(T data)
    {
        return data;
    }
}