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
            
            while(n > 10000) 
            { 
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10000; i++)
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
