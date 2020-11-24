using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob14
{
    class Program
    {
        static void Main(string[] args)
        {
			int n, a, b;
			a = 0;
            Console.WriteLine("n = ");
			n = int.Parse(Console.ReadLine());
			b = n;
			while (n > 0)
			{
				a = a * 10 + n % 10;
				n = n / 10;
			}
			if (a == b)
			{
				Console.WriteLine("Este palindrom!");
			}
			else
			{
                Console.WriteLine("Nu este palindrom!");
			}

			Console.ReadKey();
		}
    }
}
