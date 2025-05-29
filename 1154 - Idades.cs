using System;
using System.Globalization;
using System.Linq.Expressions;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, incr, somaIdades;
            idade = double.Parse(Console.ReadLine());
            incr = 0;
            somaIdades = 0;

            while(idade > 0) 
            {
                somaIdades = somaIdades + idade;
                incr++;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double)(somaIdades / incr);

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
