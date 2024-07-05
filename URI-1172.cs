using System;

class URI
{

    static void Main(string[] args)
    {

        int[] Vet = new int[10];

        for (int i = 0; i < Vet.Length; i++)
        {
            Vet[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Vet.Length; i++)
        {
            if (Vet[i] == null || Vet[i] <= 0)
            {
                Vet[i] = 1;
            }
            Console.WriteLine($"X[{i}] = {Vet[i]}");
        }

    }

}
