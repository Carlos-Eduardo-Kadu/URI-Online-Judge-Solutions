using System;
using System.Text;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int soma = 0;
        int incre = 0;

        while (z <= x)
        {
            z = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= z; i++)
        {
            if (soma <= z)
            {
                incre++;
            }
            soma = soma + x;
            x++;
        }
        Console.WriteLine(incre);
    }
}
