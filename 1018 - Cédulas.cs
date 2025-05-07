using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor, valorDividido;
            valor = int.Parse(Console.ReadLine());
            valorDividido = valor;
            int[] nota = {100, 50, 20, 10, 5, 2, 1};

            Console.WriteLine(valorDividido);
            foreach (int notas in nota)
            {
                valorDividido = valor / notas;
                valor %= notas;

                Console.WriteLine(valorDividido + " nota(s) de R$ "+notas+",00");
            }

        }
    }
