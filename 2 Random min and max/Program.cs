using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Random_min_and_max
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int min = 50, max = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
                if (array[i] > max)
                    max = array[i];
                else if (array[i] < min)
                    min = array[i];
            }
            max += min;
            Console.WriteLine();
            Console.WriteLine("Сумма максимального и минимального равна {0}", max);
            Console.ReadKey();
        }
    }
}
