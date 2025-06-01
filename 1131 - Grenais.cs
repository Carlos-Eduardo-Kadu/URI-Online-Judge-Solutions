using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int laco = 1;
            int cont = 0;
            int vitInter = 0;
            int vitGremio = 0;
            int empate = 0;
            int novoGrenal = 1;
            while(novoGrenal == 1) 
            {
                string[] gols = Console.ReadLine().Split(' ');
                int golInter = int.Parse(gols[0]);
                int golGremio = int.Parse(gols[1]);

                if (golGremio > golInter)
                {
                    vitGremio++;
                }
                else if (golInter > golGremio)
                {
                    vitInter++;
                }
                else 
                {
                    empate++;
                }

                cont++;

                do
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoGrenal = int.Parse(Console.ReadLine());
                } while (novoGrenal != 1 && novoGrenal != 2);

            }
            Console.WriteLine(cont + " grenais");
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empate);
            if (vitInter > vitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if(vitGremio > vitInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else 
            {
                Console.WriteLine("Nao houve vencedor");
            }

        }
    }
}
