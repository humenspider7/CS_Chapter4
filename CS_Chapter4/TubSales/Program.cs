using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter salesperson initial: A B or E: ");
                string input = Console.ReadLine();
                if (input == "Z") break;
            }
        }
    }
}
