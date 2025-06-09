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

            for(int i = 0; i < n; i++) 
            {
                string[] numeros = Console.ReadLine().Split(' ');
                double x = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                double y = double.Parse(numeros[1], CultureInfo.InvariantCulture);

                if (y == 0) 
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
