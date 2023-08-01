public class Program
{
    static void Main(string[] args)
    {
        // create an instance of Student with data type string
        Student<string> student1 = new Student<string>("Jack");

        // create an instance with data type int
        Student<int> student2 = new Student<int>(12);

    }
}

// define a generics class named Student
public class Student<T>
{
    // define a variable of type T
    public T StudentID;

    // define a constructor of the Student class
    public Student(T StudentID)
    {
        this.StudentID = StudentID;
        Console.WriteLine("StudentID: "+ this.StudentID);
    }
}