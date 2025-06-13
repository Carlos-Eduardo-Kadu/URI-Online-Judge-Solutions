using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a = 1, b = 1, c = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                b = a;
                a = c;
                c = a + b;
                Console.Write($"{a} ");
            }
        }
    }
}
