using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_____WHERE clause example_____");
            Where.WhereExample();

            Console.WriteLine("\n_____FROM query example_____");
            From.FromQueryExample();

            Console.WriteLine("\n_____SELECT example_____");
            Select.SelectExample();
        }
    }
}
