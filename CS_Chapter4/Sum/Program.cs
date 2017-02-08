using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            int sum=0;
            int input = 0;
            while(input!= 999)
            {
                Console.WriteLine("Enter input: ");
                string enter = Console.ReadLine();
                input = Convert.ToInt32(enter);
                sum = sum + input;
            }
            Console.WriteLine((sum - 999));
        }
    }
}
