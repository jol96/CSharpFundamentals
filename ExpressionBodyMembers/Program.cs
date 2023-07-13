public class Program 
{ 
    public static void Main(string[] args)
    {

    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    //public override string ToString()
    //{
    //    return $"{Name} who age is {Age}";
    //}

    // ToString can be written as using expression-body memeber 
    public override string ToString() => $"{Name} who age is {Age}";
}