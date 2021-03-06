using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var nx = ReadInts();
            var l = ReadInts();
            var ans =0;
            var tmp = 0;

            var list = new List<int>() { 0 };
            for (int i = 0; i < nx[0]; i++)
            {
                list.Add(tmp + l[i]);
                tmp += l[i];
            }
            foreach (var item in list)
            {
                if (item <= nx[1]) ans++;
            }
            WriteLine(ans);
        }


        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }

        //最大公約数

        public static int Gcd(int a, int b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }
            while (b != 0)
            {
                var reminder = a % b;
                a = b;
                b = reminder;
            }
            return a;
        }

        //最小公倍数
        public static int Lcm(int a, int b)
        {
            return a * b / Gcd(a, b);
        }

        //文字数を数える
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
        static long fibonacci(int n)
        {
            switch (n)
            {
                case 0:
                case 1:
                    return n;
                default:
                    return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }
    }
}
