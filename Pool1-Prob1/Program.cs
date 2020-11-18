using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Introduceti a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Ecuatie imbosibila ");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("x este  = " + x);
            }
            Console.ReadKey();
        }
    }
}
