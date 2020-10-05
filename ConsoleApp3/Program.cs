using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

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

            for (int i = 0; i < pee.Length - 1; i++)
            {
                int j = i;
                for (; j < pee.Length && pee[i] == pee[j]; j++)
                {

                }
                int currentCount = j - i;
                if (currentCount >= maxCount)
                {
                    maxCount = currentCount;
                    value = pee[i];
                }
            }
            Console.WriteLine($"{maxCount}, {value}");
            Console.WriteLine(Fib2(20));
        }
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
        static bool Apple(string a, string b)
        {
            char[] A = a.ToCharArray();
            Array.Sort(A);
            char[] B = b.ToCharArray();
            Array.Sort(B);
            for (int i = 0; i < A.Length - 1; i++)
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

        static void Pie(LinkedList<string> pee, LinkedList<string> s)
        {
            foreach (var n in s)
            {
                pee.AddLast(n);
            }
        }

        static void NumSwap()
        {
            int ReadInt(string prompt)
            {
                
                int x;
                do
                {
                    Console.WriteLine(prompt);
                } while (!int.TryParse(Console.ReadLine(), out x));
                return x;
            }
            var x = ReadInt("First Number x=_");
            var y = ReadInt("Second Number y=_");
            y = x + y;
           x = y - x;
           y = y - x;
            Console.WriteLine($"{x} {y}");
         }
  
        static void Q6()
        {
            //given sum and array find all pairs that equal the sum
            int[] pee = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 5, 6, 8, 9, 9, 7, 6, 5, 3, 9, 1, 1, 1, 1, 1, 2, 3, 5, 123, 12, -2, 4, -3 };
            int sum = 4;


            foreach (int a in pee)
            {
                for (int i = 1; i < pee.Length - 1; i++)
                {
                    if (a + i == sum)
                    {
                        string pairs = "" + a + "+" + i;
                    }
                }
            }
        }
        //Write a function to count a total number of set bits in a 32 bit Integer? (Solution)
        public static uint SetBitCount(uint i)
        {
            uint poohead = 0;
            while(i != 0)
            {
                poohead += i & 1;
                i >>= 1;
            }
            return poohead;
        }
        public static int Fibonacci(int n)
        {
            //im sorry
            int[] num = new int[n + 1];
            num[0] = 0;
            num[1] = 1;
            if (n <= 1)
            {
                return n;
            }
            for (int i = 2; i <= n; i++)
            {
                int a = num[i - 2] + num[i - 1];
                num[i] = a;

            }
            return num[n];
        }
        public static int Fib2(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib2(n - 1) + Fib2(n - 2);
        }
        public static string BillGates()
        {
            Console.WriteLine("gimme ya change peehead");
            char[] tyler1 = Console.ReadLine().ToCharArray();
            foreach (char x in tyler1);
            {
                for ( int i = 1 ; i<tyler1.Length - 1; i++)
                {
                    if (tyler1[x] == tyler1[])
                    string asdj = $"{tyler1[i - 1]}";
                }
            }
            return asdj;
        }
        public static 
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

        

 

       

