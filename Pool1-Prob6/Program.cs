using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
        
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Pot fi laturile unui triunghi!");
            }
            else
            {
                Console.WriteLine("Nu pot fi laturile unui triunghi!");
            }


            Console.ReadKey();
        }
    }
}
