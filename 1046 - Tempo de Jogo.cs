using System;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            int hI = int.Parse(v[0]);
            int hF = int.Parse(v[1]);

            int duracao;

            if (hI == hF)
            {
                duracao = 24;
            }
            else if (hF > hI)
            {
                duracao = hF - hI;
            }
            else
            {
                duracao = (24 - hI) + hF;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
