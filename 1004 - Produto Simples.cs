using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, prod;

            a =  int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            prod = a * b;

            Console.WriteLine("PROD = "+ prod);
        }
    }
}
