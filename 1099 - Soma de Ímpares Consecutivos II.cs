using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, incre = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int x = int.Parse(numeros[0]);
                int y = int.Parse(numeros[1]);

                if(x > y) 
                { 
                    int temp = x; 
                    x = y;
                    y = temp;
                }

                for(int j = x + 1; j < y; j++)
                { 
                    if(j % 2 != 0)
                    {
                        incre = incre + j;
                    }
                }
                Console.WriteLine(incre);

                incre = 0;
            }
        }
    }
}
