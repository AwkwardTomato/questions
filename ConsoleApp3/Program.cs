using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace ConsoleApp3
{
    /*class Program
    {
        static void Main()
        {
            int[] pee = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 5, 6, 8, 9, 9, 7, 6, 5, 3, 9, 1, 1, 1, 1, 1, 2, 3, 5, 123, 12 };
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
                if (currentCount >= maxCount)
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
    

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
    class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            var nodeCache = new List<ListNode>();
            while (true)
            {
                if (nodeCache.Contains(head.next))
                {
                    return true;
                }
                else if (head.next == null)
                {
                    return false;
                }

                nodeCache.Add(head);
                head = head.next;

            }

        }
    }
    class Poopoo
    {
        static void Pie(LinkedList<string> pee, LinkedList<string> s)
        {
            foreach (var n in s)
            {
                pee.AddLast(n);
            }
        }
    }
    class Question4
    {
        static bool Apple(string a, string b)
        {
            char[] A = a.ToCharArray();
            Array.Sort(A);
            char[] B = b.ToCharArray();
            Array.Sort(B);
             for (int i = 0; i < A.Length - 1; i++ )
            {
                if (B[i] == A[i])
                {
                    i++;
                }
                else
                {
                    return false;
                }
            }
            return true;



        }
    }
    class Niff
    {
        static void Q5()
        {
            Console.WriteLine("First Number x=_");
            string x = Console.ReadLine();
            Int32.Parse(x);
            Console.WriteLine("second Number y=_");
            string y = Console.ReadLine();
            Int32.TryParse(y);
            // x=3 y=2
            y = x + y;
            x = y - x;
            y = y - x;
        }
    }*/
    class Hasio
    {
        static void Q6()
        {
            //given sum and array find all pairs that equal the sum
            int[] pee = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 5, 6, 8, 9, 9, 7, 6, 5, 3, 9, 1, 1, 1, 1, 1, 2, 3, 5, 123, 12, -2, 4, -3 };
            int sum = 4;
            

            foreach (int a in pee)
            {
                 for (int i = 1; i < pee.Length - 1; i++ )
                {
                    if (a+i == sum)
                    {
                        string pairs = "" + a + "+" + i;
                    }
                }
            }



        }
    }

}
