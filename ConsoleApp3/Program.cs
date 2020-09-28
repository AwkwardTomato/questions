using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
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
 
    public class Solution
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
}
