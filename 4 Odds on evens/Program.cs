using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Odds_on_evens
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int c=0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
                if (array[i] > 0 && array[i] % 2 != 0 && i % 2 == 0)
                    c++;
            }
            Console.WriteLine();
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
