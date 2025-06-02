using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n =  int.Parse(Console.ReadLine());

            while(n > 10000) 
            { 
                n =  int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++) 
            {
                x = int.Parse(Console.ReadLine());  

                if (x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (x % 2 == 0 && x > 0)
                { 
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x % 2 != 0 && x < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else 
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
