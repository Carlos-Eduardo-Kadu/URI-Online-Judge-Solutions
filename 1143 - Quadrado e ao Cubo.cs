using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k = 1, l = 1, m = 1, c = 2;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            { 
                Console.WriteLine($"{k} {l} {m}");

                k += 1;
                l = c * k;
                m = c * l;
                c++;
            }
            
        }
    }
}
