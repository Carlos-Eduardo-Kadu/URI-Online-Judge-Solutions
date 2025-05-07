using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consumoMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = x / y;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture)+" km/l");
        }
    }
}
