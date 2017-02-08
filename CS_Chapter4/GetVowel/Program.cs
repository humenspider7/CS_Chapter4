using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
         while(true)
            {
                Console.WriteLine("Enter value: ");
                string val = Console.ReadLine();
                //if (val == "A" || val == "a" || val == "e" || val == "E" || val == "i" || val == "I" || val == "O" || val == "o" || val == "u" || val == "U")
                if ("AEIOU".Contains(val.ToUpper()))
                    Console.WriteLine("OK!");
               else if (val == "!")
                    break;
                else Console.WriteLine("No");

                //error with the else statement.  It shows up even if a vowel is entered;
            }
        }
    }
}
