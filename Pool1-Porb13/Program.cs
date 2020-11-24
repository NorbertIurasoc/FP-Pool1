using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Porb13
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Introduceti anul:");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("Este an bisect!");
            }
            else
            {
                Console.WriteLine("Nu este an bisect!");
            }
            Console.ReadKey();


        }
    }
}
