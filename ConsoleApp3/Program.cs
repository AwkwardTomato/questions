using System;
using System.Linq;
namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            int[] pee = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 5, 6, 8, 9, 9, 7, 6, 5, 3, 9,1,1,1,1,1,2,3,5, 123,12 };
            Array.Sort(pee);
            int maxCount = 0;
            int value = 0;

            for (int i = 0; i < pee.Length - 1; i++ )
            {
                int j = i;
                for ( ; j < pee.Length && pee[i] == pee[j]; j++)
                {

                }
                int currentCount= j-i;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    value = pee[i];
                }
            }
            Console.WriteLine($"{maxCount}, {value}");
            
            //Console.WriteLine(string.Join(",", pee));

            //foreach (int p in pee)
            //{
            //    Console.WriteLine(p);
            //}
        }

        
    }
}
