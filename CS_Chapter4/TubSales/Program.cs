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
                String sp = "";
                double apay = 0, bpay = 0, epay = 0;
                while (sp.ToLower() != "z")
                {
                    Console.WriteLine("Pick a salesperson: Andrea, Brittany, or Eric");
                    sp = Console.ReadLine();
                    if (sp.ToLower().StartsWith("a"))
                    {
                        Console.WriteLine("What were the tubs Andrea sold worth: ");
                        apay += Convert.ToDouble(Console.ReadLine());
                    }
                    else if (sp.ToLower().StartsWith("b"))
                    {
                        Console.WriteLine("What were the tubs Brittany sold worth: ");
                        bpay += Convert.ToDouble(Console.ReadLine());
                    }
                    else if (sp.ToLower().StartsWith("e"))
                    {
                        Console.WriteLine("What were the tubs Eric sold worth: ");
                        epay += Convert.ToDouble(Console.ReadLine());
                    }

                }
                double acom = apay * .10, bcom = bpay * .10, ecom = epay * .10;
                Console.WriteLine("\t\tSales\t\tCommission\nAndrea\t\t" + apay.ToString("C") + "\t\t" + acom.ToString("C") + "\nBrittany\t" + bpay.ToString("C") + "\t\t" + bcom.ToString("C") + "\nEric\t\t" + epay.ToString("C") + "\t\t" + ecom.ToString("C"));
            }
        }
    }
}
