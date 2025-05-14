using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            string[] val = Console.ReadLine().Split(' ');
            a = int.Parse(val[0]);
            b = int.Parse(val[1]);

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
