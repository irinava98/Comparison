using System;
using System.Collections.Generic;
using System.Linq;

namespace Comparison
{
    // public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    public delegate int CompDelegate(int a,int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            CompDelegate comp = Comparison2;
            Console.WriteLine(ComparisonWithDelegate(-6, 5, comp));
            Console.WriteLine(Comparison(1, 5, Comparison1));
            Console.WriteLine(Comparison(-5, 2, Comparison2));
        }

   
        public static int Comparison(int a,int b,Func<int,int,int> comparator)
        {
            return comparator(a, b);
        }

        public static int ComparisonWithDelegate(int a, int b, CompDelegate comparator)
        {
            return comparator(a, b);
        }

        public static int Comparison1(int a,int b)
        {
            if (a > b)
            {
                Console.WriteLine($"{a} is bigger.");
                return a;
            }
            else
            {
                Console.WriteLine($"{b} is bigger.");
                return b;
            }
        }

        public static int Comparison2(int a, int b)
        {
            if (Math.Abs(a) > Math.Abs(b))
            {
                Console.WriteLine($"{a} is bigger.");
                return a;
            }
            else
            {
                Console.WriteLine($"{b} is bigger.");
                return b;
            }
        }


    }
  
}
