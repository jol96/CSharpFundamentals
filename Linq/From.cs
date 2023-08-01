using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class From
    {
        public static void FromQueryExample()
        {
            string[] names = { "Hansel", "Gretel", "Helga", "Gus" };

            // Query syntax
            var query = 
                from name in names
                where name.Contains('a')
                select name;

            foreach(var name in query)
            {
                Console.WriteLine($"{name} contains letter a.");
            }
        }
    }
}
