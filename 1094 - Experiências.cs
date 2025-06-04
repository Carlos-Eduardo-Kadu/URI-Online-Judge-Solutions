using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int testes = int.Parse(Console.ReadLine());
           double somaRato = 0, somaSapo = 0, somaCoelho = 0, qtdTotal = 0;
           double perRato = 0, perSapo = 0, perCoelho = 0;
            
            for (int i = 0; i < testes; i++)
            {
                string[] especieQtd = Console.ReadLine().Split(' ');

                double qtd = int.Parse(especieQtd[0], CultureInfo.InvariantCulture);
                char especie = char.Parse(especieQtd[1]);

                if (especie == 'R')
                {
                    somaRato = somaRato + qtd;
                }
                else if (especie == 'S')
                {
                    somaSapo = somaSapo + qtd;
                }
                else
                {
                    somaCoelho = somaCoelho + qtd;
                }
                qtdTotal += qtd;
            }

            perRato = (somaRato * 100) / qtdTotal;
            perSapo = (somaSapo * 100) / qtdTotal;
            perCoelho = (somaCoelho * 100) / qtdTotal;

            Console.WriteLine("Total: " + qtdTotal + " cobaias");
            Console.WriteLine("Total de coelhos: " + somaCoelho);
            Console.WriteLine("Total de ratos: " + somaRato);
            Console.WriteLine("Total de sapos: " + somaSapo);
            Console.WriteLine("Percentual de coelhos: " + perCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + perRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + perSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
