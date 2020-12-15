using System;
using System.Collections;
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
            int[] peo = { 1, 1, 2, 5, 6, 8, 9 };
            ListNode head = new ListNode(0);
            ListNode node = head;
            for (int i = 1; i < 14; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }
            Console.WriteLine(Duplicates(new int[] {1, 2,3}));
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
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
            while (i != 0)
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
        //Write a function to remove duplicate characters from String? (Solution)
        public static string BillGates(string asdf)
        {
            char[] tyler1 = asdf.ToCharArray();
            foreach (char x in tyler1)
            {
                for (int i = 1; i < tyler1.Length - 1; i++)
                {
                    if (x == tyler1[i])
                    {
                        asdf = asdf.Replace($"{tyler1[i]}", "_");
                    }
                }
            }
            return asdf;
        }
        public static int ThirdFromLast(ListNode LST)
        {
            return FromLast(LST, 3);
        }
        //How to find the 3rd element from end, in a singly linked, in a single pass? (Solution)
        public static int FromLast(ListNode LST, int place)
        {
            int[] nodeCache = new int[place];
            int i = 0;
            for (; LST != null; i++)
            {
                nodeCache[i % place] = LST.val;
                LST = LST.next;
            }
            return nodeCache[i % place];
            /*var queue = new Queue<int>();
            while(LST != null)
            {
                queue.Enqueue(LST.val);
                if(queue.Count > 3)
                {
                    queue.Dequeue();
                }
                LST = LST.next;
            }
            return queue.Dequeue();*/
        }
        /*        public class ListNode
        {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }*/
        //How to calculate factorial using recursion in C#? (Solution)
        public static uint RecurseFact(uint i)
        {
            if (i == 1)
            {
                return 1;
            }
            return RecurseFact(i - 1) * i;
        }
        public static int[] ToIntArray(int x)
        {
            string p = x.ToString();
            char[] c = p.ToCharArray();
            int[] b = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                b[i] = Convert.ToInt32(c[i]);
            }
            return b;
        }
        public static double[] ToDoubleArray(double x)
        {
            string p = x.ToString();
            char[] c = p.ToCharArray();
            double[] b = new double[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                String temp = c[i].ToString();
                b[i] = Convert.ToDouble(temp);
            }
            return b;
        }
        //C# program to check if a number is Armstrong number or not? (Solution)
        public static bool Armstrong(double x)
        {
            double[] Arm = ToDoubleArray((int)x);
            double sum = 0;
            foreach (double i in Arm)
            {
                sum += Math.Pow(i, 3);
            }
            Console.WriteLine(sum);
            if (sum == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Algorithm to check if a number is Prime or not? (Solution)
        public static bool Prime(int x)
        {
            int i, m = 0;
            if (x == 0)
            {
                Console.WriteLine("Your anoying tbh");
                return false;
            }
            m = x / 2;
            for (i = 2; i <= m; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Algorithm to check if a number is Palindrome? (Solution)
        public static bool Palindrome(int x)
        {
            int[] pal = ToIntArray(x);
            for (int i = 0; i < pal.Length / 2; i++)
            {
                if (pal[i] != pal[pal.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        //Algorithm to find if Array contains duplicates? (Solution)

        public static bool Duplicates(int[] POP)
        {
            for(int j = 0; j < POP.Length - 1; j++)
            {
                for (int i = j + 1; i < POP.Length; i++)
                {
                    if (POP[j] == POP[i])
                    {
                        return true;
                    }
                }
            }
            return false;
            /*Array.Sort(POP);
            int i = 0;
            for (; i < POP.Length - 1; i++)
            {
                if (POP[i] == POP[i + 1])
                {
                    return true;
                }
            }
            return false;*/
        }
        //Write code to reverse a linked list, if you able to do it using loops, try to solve with recursion? (Solution)
        public static void Revrse(LinkedList<string> pogg)
        {
            int x = pogg.Count;
            if (x <= 0)
            {
                return;
            }
        }
        /*
        //How to rotate an array by a given pivot ? (Solution)
        public static void Pivot(Array[] x, int x)
        {

        }
        //How to remove duplicates from a sorted linked list? (Solution)
        public static void LinkDuplicates(LinkedList x)
        {

        }
        */
    }
}