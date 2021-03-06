using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Numerics;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var N = ReadLong();
            var ans = 0;
            for (long i = 1; i < N; i++)
            {
                var n = long.Parse(i + "" + i);
                if (n <= N)
                {
                    ans++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(ans);
        }
        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
