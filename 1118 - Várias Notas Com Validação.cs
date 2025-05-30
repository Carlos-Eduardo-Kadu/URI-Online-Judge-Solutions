using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0, nota2 = 0, novoCalculo = 1, media, qtdNotas = 0;

            while (novoCalculo == 1)
            {
                while (qtdNotas < 2)
                {
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (nota >= 0 && nota <= 10)
                    {
                        if (qtdNotas < 2)
                        {
                            if (qtdNotas == 0)
                            {
                                nota1 += nota;
                            }
                            else if (qtdNotas == 1)
                            {
                                nota2 += nota;
                            }
                            qtdNotas++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = double.Parse(Console.ReadLine());
                qtdNotas = 0;
                nota1 = 0;
                nota2 = 0;
            }

        }
    }
}

/-------ou-------/

using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0, nota2 = 0, novoCalculo = 1, media, qtdNotas = 0;

            while (novoCalculo == 1)
            {
                while (qtdNotas < 2)
                {
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (nota >= 0 && nota <= 10)
                    {
                        if (qtdNotas == 0)
                        {
                            nota1 = nota;
                        }
                        else if (qtdNotas == 1)
                        {
                            nota2 = nota;
                        }
                        qtdNotas++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                media = (nota1 + nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                do
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = double.Parse(Console.ReadLine());
                } while (novoCalculo != 1 && novoCalculo != 2);

                qtdNotas = 0;
                nota1 = 0;
                nota2 = 0;
            }
        }
    }
}
