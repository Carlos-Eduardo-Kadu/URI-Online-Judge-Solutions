using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int incre = 0;

        int[] vet = new int[1000];

        for (int i = 0; i < vet.Length; i++)
        {
            if (incre == t)
            {
                incre = 0;
            }
            vet[i] = incre;
            incre++;
        }

        for (int i = 0;i < vet.Length;i++)
        {
            Console.WriteLine($"N[{i}] = {vet[i]}");
        }
    }
}
