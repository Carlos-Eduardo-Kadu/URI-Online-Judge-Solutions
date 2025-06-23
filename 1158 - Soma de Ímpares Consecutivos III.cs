using System;

class Program
{
    static void Main()
    {
        int n, soma = 0; 
        n =  int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int x = int.Parse(numeros[0]);
            int y = int.Parse(numeros[1]);

            for (int j = 0; j < y * 2; j++)
            {
                if (x % 2 != 0) 
                {
                    soma = soma + x;
                }
                x++;
            }
            Console.WriteLine(soma);
            soma = 0;
        }
    }
}
