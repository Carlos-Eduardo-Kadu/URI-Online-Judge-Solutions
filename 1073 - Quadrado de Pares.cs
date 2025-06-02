using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            while (5 >= n || n >= 2000)
            {
                n = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i+ "^" + "2" +" = " + i*i);
                }
            }
        }
    }
}
