using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE
            int result = 0;
            for(int i =1; i <= 50; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }
    }
}
