using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, y = 1;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                y = y * i;
            }
            Console.WriteLine(y);

        }
    }
}
