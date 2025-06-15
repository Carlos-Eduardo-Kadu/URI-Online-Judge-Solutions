using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, incre = 0;

            for(int i = 0; i < 5; i++) 
            {
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0) 
                {
                    incre++;
                }
            }
            Console.WriteLine(incre + " valores pares");
        }
    }
}
