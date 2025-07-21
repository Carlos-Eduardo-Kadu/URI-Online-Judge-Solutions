using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int[] vet = new int[20];
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(vet);
        for (int i = 0;i < vet.Length;i++) 
        {
            Console.WriteLine($"N[{i}] = {vet[i]}");
        }
    }
}
