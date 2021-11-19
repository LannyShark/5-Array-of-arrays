using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            int average=0;
            Console.WriteLine("Введите числа");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int a in array)
            {
                average += a;
            }
            average /= n;
            Console.WriteLine("Среднее арифметическое равно {0}", average);
            Console.ReadKey();
        }
    }
}
