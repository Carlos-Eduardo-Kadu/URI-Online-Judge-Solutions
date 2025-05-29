using System;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                int somaPares = 0;
                int paresEncontrados = 0;
                int numeroAtual = x;

                while (paresEncontrados < 5)
                {
                    if (numeroAtual % 2 == 0)
                    {
                        somaPares += numeroAtual;
                        paresEncontrados++;
                    }
                    numeroAtual++;
                }

                Console.WriteLine(somaPares);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
