using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ReadInt();
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var st = Read();
                list.Add(st);
            }
            var X = Read();

            var ans = 0;
            var Count = false;
            for (int i = 0; i < n; i++)
            {
                if (Count == true)
                {
                    ans += int.Parse(list[i].Split(' ')[1]);
                }
                if(list[i].Split(' ')[0] == X)
                {
                    Count = true;
                }
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
    }
}
