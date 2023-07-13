using System.Text.Json.Serialization;

public class Program
{

    // Using:
    // Allows for using types from other namespaces.
    // Without the using system we wouldn't be able to use the Console.WriteLine

    // Using can also be used to create aliases for some type names
    // This can be useful for when we have conflicting type names and we want to use them both in a
    // single file.
    // Example Person


    public static void Main(string[] args)
    {
        using PersonDto = Dtos.Person;
        using PersonDomain = DomainObjects.Person;

        var personDto = new PersonDto();
        var personDomain = new PersonDomain();
    }

}

namespace DomainObjects
{
    public class Person
    {
        public string Name { get; set; }
    }
}

namespace Dtos
{
    public class Person
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
