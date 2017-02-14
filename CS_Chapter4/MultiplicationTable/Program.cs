using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {   //DONE
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for( int y = 1; y <= 10; y++)
                {
                    Console.Write(y * i + "\t");
                }
                Console.Write("\n\n");

            }
        }
    }
}
