using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1_Prog16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = InitArray(5, 0, 100);

            
            PrintArray(arr);

            SelectionSort(arr);

            
            PrintArray(arr);

            Console.ReadKey();

        }

        private static void SelectionSort(int[] arr)
        {
            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                aux = arr[k];
                arr[k] = arr[i];
                arr[i] = aux;
            }
        }
        private static void InsertionSort(int[] arr)
        {
            int aux;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int k = i; k > 0 && arr[k] < arr[k - 1]; k--)
                {
                    aux = arr[k];
                    arr[k] = arr[k - 1];
                    arr[k - 1] = aux;
                }

            }


        }

        private static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(); 
        }

        private static int[] InitArray(int length, int min, int max)
        {
            int[] v = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
            return v;
        }

        

            
        }

    }

