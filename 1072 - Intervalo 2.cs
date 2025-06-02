using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, iN = 0, ouT = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    iN++;
                }
                else
                { 
                    ouT++;
                }
            }
            Console.WriteLine( iN + " in");
            Console.WriteLine(ouT + " out");
        }
    }
}
