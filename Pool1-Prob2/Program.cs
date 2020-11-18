using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, dt;
            double x1, x2;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0) Console.WriteLine("Ecuatie imposibila");
                    else Console.WriteLine("Ecuatie imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatie de gradul 1 cu x1 = " + x1);
                }
            else
            {
                dt = b * b - 4 * a * c;
                if (dt < 0)
                    Console.WriteLine("Ecuatia are solutii complexe");
                else
                {
                    if (dt == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("x1 = x2 = " + x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                        x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                        Console.WriteLine("Solutiile sunt x1 = " + x1 + " x2 = " + x2);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
