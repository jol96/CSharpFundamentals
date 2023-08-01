public class Program
{
    public static void Main(string[] args)
    {
        // create an instance of employee class by specifying T as a string
        Employee<string> employeeName = new();

        // call displayData() generics method and pass a string value - "Jack"
        employeeName.DisplayData("Jack");

        // create an instance of Employee class by specifying T as an int
        Employee<int> employeeId = new();

        // call displayData() generic method and pass an int
        employeeId.DisplayData(12);
    }
    
}

public class Employee<T>
{
    // define a generic method
    public void DisplayData(T data)
    {
        Console.WriteLine("Data passed: "+data);
    }
}