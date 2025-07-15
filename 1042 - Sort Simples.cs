using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int temp = 0;
        num1 = int.Parse(numeros[0]);
        num2 = int.Parse(numeros[1]);
        num3 = int.Parse(numeros[2]);

        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        if (num2 > num3)
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }
        if (num1 > num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine($"{num1}");
        Console.WriteLine($"{num2}");
        Console.WriteLine($"{num3}");
        Console.WriteLine();
        foreach (string str in numeros)
        {
            Console.WriteLine(str);
        }
    }
}
