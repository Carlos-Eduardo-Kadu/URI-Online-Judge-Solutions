using System;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int N = 0;

        for (int i = 1; i < valores.Length; i++)
        {
            int temp = int.Parse(valores[i]);
            if (temp > 0)
            {
                N = temp;
                break;
            }
        }

        while (N <= 0)
        {
            N = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < N; i++)
        {
            soma += A + i;
        }

        Console.WriteLine(soma);
    }
}
