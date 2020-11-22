using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux;

            Console.WriteLine("Introduceti a: ");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti b: ");
            b = int.Parse(Console.ReadLine());
            
            aux = a; a = b; b = aux;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.ReadKey();
        }
    }
}
