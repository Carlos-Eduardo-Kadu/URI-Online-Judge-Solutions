using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            double notas, media;
            int limi = 0;
            double[] vet = new double[3];
            while (limi < 3) 
            { 
                notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[limi] = notas;
                limi++;

            }

            media = (vet[0] * 2 + vet[1] * 3 + vet[2] * 5) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
