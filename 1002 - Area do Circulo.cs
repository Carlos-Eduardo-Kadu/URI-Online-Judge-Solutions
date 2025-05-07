using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, n, raio;

            n = 3.14159;
            raio = Math.Pow(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture),2);
            area = n * raio;

            Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
