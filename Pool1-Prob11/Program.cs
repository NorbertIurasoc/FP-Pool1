﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prob11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cif, invers = 0; ;
            Console.WriteLine("Introduceti numarul: ");
            n = int.Parse(Console.ReadLine());
            
            while (n > 0)
            {
                cif = n % 10;
                invers = invers * 10 + cif;
                n = n / 10;
            }

            Console.WriteLine(invers);

            Console.ReadKey();
        }
    }
}
