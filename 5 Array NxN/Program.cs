using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Array_NxN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                array[i,0] = (i % 2 == 0) ? 1 : 0;
                Console.Write("{0,3}", array[i, 0]);
                for (int j = 1; j < n; j++)
                {
                    array[i, j] = (array[i,j-1] == 0) ? 1 : 0;
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
