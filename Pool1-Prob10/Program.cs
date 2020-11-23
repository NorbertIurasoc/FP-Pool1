using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, nr=0;
            Console.WriteLine("Introduteti numarul:");
            n = int.Parse(Console.ReadLine());

           for(d = 2; d <= n / 2; d++)
            {
                if (n % d == 0)
                    nr++;
            }
            if (nr == 0)
                Console.WriteLine("Numarul este prim!"); 
            else
                Console.WriteLine("Numarul nu este prim!");
           
            
            Console.ReadKey();                     
        }
    }
}
