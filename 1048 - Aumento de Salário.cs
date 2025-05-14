using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double por, aumento, reajuste;

            if (salario <= 400.00)
            {
                por = 15;
            }
            else if (salario <= 800.00)
            {
                por = 12;
            }
            else if (salario <= 1200.00)
            {
                por = 10;
            }
            else if (salario <= 2000.00)
            {
                por = 7;
            }
            else
            {
                por = 4;
            }

            aumento = salario * por / 100;
            reajuste = salario + aumento;

            Console.WriteLine("Novo salario: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + por + " %");
        }
    }
}
