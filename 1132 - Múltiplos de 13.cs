using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) 
            {
                int inter = x;
                x = y;
                y = inter;
            }

            for (int i = x; i <= y; i++)
            { 
                if(i % 13 != 0) 
                {
                    soma = soma + i;

                }
            }
           
            Console.WriteLine(soma);
        }
    }
}
