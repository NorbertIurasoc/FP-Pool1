using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("Se divide.");

            }
            else
            {
                Console.WriteLine("Nu se divide.");
            }



            Console.ReadKey();
        }
    }
}
