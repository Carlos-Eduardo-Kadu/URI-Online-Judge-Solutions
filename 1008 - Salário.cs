using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, horas;
            double salH, salario;
        
            num = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * salH;

            Console.WriteLine("NUMBER = "+num);
            Console.WriteLine("SALARY = U$ "+salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
