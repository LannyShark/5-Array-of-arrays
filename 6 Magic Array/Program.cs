using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Magic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] sumStrings = new int[n];
            int[] sumCulumns = new int[n];
            int[] sumDiagonals = new int[2] { 0, 0 };
            bool mem = true;
            for (int i = 0; i < n; i++)
            {
                sumStrings[i] = 0;
                sumCulumns[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    sumStrings[i] += array[i, j];
                    sumCulumns[j] += array[i, j];
                    if (i == j)
                        sumDiagonals[0] += array[i, j];
                    if (i+j == n-1)
                        sumDiagonals[1] += array[i, j];
                }
            }
            if (sumDiagonals[0] == sumDiagonals[1])
            {
                for (int i = 1; mem && i < n; i++)
                {
                    mem = (sumStrings[i] == sumStrings[i - 1] && sumCulumns[i] == sumCulumns[i - 1]) ? true : false;
                }
            }
            else
                mem = false;
            if (mem)
                Console.WriteLine("Это магический квадрат");
            else
                Console.WriteLine("Это не магический квадрат");
            Console.ReadKey();
        }
    }
}
