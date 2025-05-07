using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidadeMedia, tempoGasto;
            double litros;
            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            litros = (tempoGasto * velocidadeMedia) / 12.0;
           
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
