using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k = 1, l = 2, m = 3;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            { 
                Console.WriteLine($"{k} {l} {m} PUM");

                k += 4;
                l += 4;
                m += 4;
            }
            
        }
    }
}
