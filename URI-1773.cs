using System;

public class URI_1173
{
    public static void Main(string[] args)
    {
        int V = int.Parse(Console.ReadLine()!);
        int D = 0;
        int[] N = new int[10];

        while (V > 50)
        {
            V = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < N.Length; i++)
        {
            D = V;
            N[i] = D;
            V = V * 2;
            // Console.WriteLine($"N[{i}] = {N[i]}");
        }

        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine($"N[{i}] = {N[i]}");
        }

    }
}
