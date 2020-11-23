using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int x = sqrt(a), y = sqrt(b);
            if (sqrt(a) != floor(sqrt(a))) x++;
            for (int i = x; i <= y; i++)
            {
                int p = 1;
                if (i == 0 || i == 1) p = 0;
                else if (i % 2 == 0 && i > 2) p = 0;
                else for (int d = 3; d * d <= i; d = d + 2)
                        if (i % d == 0) p = 0;
                if (p) n++;
            }
            Console.WriteLine(n);


        }
    }
}
