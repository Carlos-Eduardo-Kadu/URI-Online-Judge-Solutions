using System;

class Program
{
    static void Main()
    {
        double nota1 = -1, nota2 = -1;
        int notasValidas = 0;

        while (notasValidas < 2)
        {
            double nota;
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                if (nota >= 0 && nota <= 10)
                {
                    if (notasValidas == 0)
                    {
                        nota1 = nota;
                    }
                    else
                    {
                        nota2 = nota;
                    }
                    notasValidas++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        double media = (nota1 + nota2) / 2;
        Console.WriteLine($"media = {media:F2}");
    }
}
