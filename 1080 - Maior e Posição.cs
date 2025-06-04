using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alocaValorMaior = 0;
            int alocaPosicao = 0;
            for(int i=1; i<=100; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor > alocaValorMaior)
                { 
                    alocaValorMaior = valor;
                    alocaPosicao = i;
                }
            }

            Console.WriteLine(alocaValorMaior);
            Console.WriteLine(alocaPosicao);
        }
    }
}
