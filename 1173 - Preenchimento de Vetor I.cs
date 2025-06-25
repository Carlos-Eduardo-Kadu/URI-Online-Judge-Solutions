using System;

class Program
{
    static void Main()
    {
        int[] vet = new int[10];
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < vet.Length; i++)
        {
            vet[i] = n;
            n = n * 2;
        }

        for(int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"N[{i}] = {vet[i]}");
        }
    }
}
