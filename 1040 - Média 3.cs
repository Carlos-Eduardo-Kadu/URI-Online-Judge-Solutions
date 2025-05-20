using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, notaexame, notaRecalculada;
            string[] notas = Console.ReadLine().Split(' ');
            nota1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            float media = (nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                notaexame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaexame.ToString("F1", CultureInfo.InvariantCulture));
                notaRecalculada = (media + notaexame) / 2;

                if (notaRecalculada >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + notaRecalculada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

