using System;

class Program
{
    static void Main()
    {
        int[] vet = new int[10];

        for (int i = 0; i < vet.Length; i++)
        {
            int numero= int.Parse(Console.ReadLine());

            if (numero == 0 || numero < 0) 
            {
                vet[i] = 1;
            }
            else
            {
                vet[i] = numero;
            }
        }

        for (int j = 0;j < vet.Length;j++)
       {
            Console.WriteLine($"X[{j}] = {vet[j]}"); 
       }
    }
}
