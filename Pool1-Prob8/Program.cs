using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());

            b = (a + b) - (a = b);

            Console.WriteLine("a = " + a + " " + "b = " + b);


            Console.ReadKey();
        }
    }
}
