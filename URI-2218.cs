using System;

class URI
{

    static void Main(string[] args)
    {

        int T = int.Parse(Console.ReadLine());
        int Soma = 0;
        int[] N = new int[T];

        for (int i = 0; i < N.Length; i++)
        {
            int qtdLinhas = int.Parse(Console.ReadLine());
            Soma = ((qtdLinhas * (qtdLinhas + 1) / 2)) + 1;
            N[i] = Soma;
        }

        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine($"{N[i]}");
        }

    }

}
