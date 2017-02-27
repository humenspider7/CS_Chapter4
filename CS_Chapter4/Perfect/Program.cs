using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1000, count = 0;
            for (int i = 1; i < num; i++)
            {
                count = 0;
                for (int p = 1; p < i; p++)
                {
                    if (i % p == 0)
                    {
                        count = count + p;
                    }
                }
                if (count == i)
                    Console.WriteLine(i);
            }
        }
    }
}
