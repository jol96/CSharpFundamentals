using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Select
    {
        public static void SelectExample()
        {
            string[] names = { "Hansel", "Gretel", "Helga", "Gus" };

            // method syntax
            var query2 = names.Where(name => name.Contains('s')).Select(name => name);

            foreach (var name in query2)
            {
                Console.WriteLine($"{name} contains letter s");
            }
        }
    }
}
