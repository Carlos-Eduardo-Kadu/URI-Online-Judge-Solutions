using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int somaImpares = 0;

            for (int i = y+1; i < x; i++)
            {

                if (i % 2 != 0)
                {
                    somaImpares = + somaImpares + i;
                }
            }
            Console.WriteLine(somaImpares);
        }
    }
}
