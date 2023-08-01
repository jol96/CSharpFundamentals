using Linq;

public class Where
{

    public static void WhereExample() 
    {
        Customer customer1 = new Customer();
        customer1.Name = "Jack";
        customer1.City = "Belfast";

        Customer customer2 = new Customer();
        customer2.Name = "Caoimhe";
        customer2.City = "Downings";

        Customer customer3 = new Customer();
        customer3.Name = "Peter";
        customer3.City = "Downings";

        List<Customer> customers = new List<Customer>();
        customers.Add(customer1);
        customers.Add(customer2);
        customers.Add(customer3);

        // method syntax
        var custQuery = customers.Where(cust => cust.City == "Belfast");


        // Query syntax
        var custQuery2 =
            from cust in customers
            where cust.City == "Downings"
            select cust;

        var custQuery3 =
            from cust in customers
            where cust.City == "Dublin"
            select cust;

        foreach (var cust in custQuery)
        {
            Console.WriteLine($"{cust.Name} lives in Belfast");
        }

        foreach (var cust in custQuery2)
        {
            Console.WriteLine($"{cust.Name} lives in Downings");
        }

        if (custQuery3.Any())
        {
            foreach (var cust in custQuery2)
            {
                Console.WriteLine($"{cust.Name} lives in Dublin");
            }
        }
        else
        {
            Console.WriteLine("No customers live in Dublin");
        }
    }
}
