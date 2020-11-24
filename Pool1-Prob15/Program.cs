using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob15
{
    class Program
    {
        static void Main(string[] args)
		{ 

			int a, b, c, aux;
            
		Console.WriteLine("Introduceti numerele: ");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());

			if (a > b)
			{
				aux = a;
				a = b;
				b = aux;
			}
			if (b > c)
			{
				aux = b;
				b = c;
				c = aux;
			}
			if (a > b)
			{
				aux = a;
				a = b;
				b = aux;
			}
            Console.WriteLine(a + " " + b + " " + c);

			Console.ReadKey();
        }
    }
}
