using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Introduteti numarul: ");

            n = int.Parse(Console.ReadLine());
            

            
                
                while (n > 9)
            {
                n = n % 10;
                
            }

            Console.WriteLine(n);


            Console.ReadKey();
        }
    }
}
