using System;

class Program
{
    static void Main()
    {
        int c;
        c = int.Parse(Console.ReadLine());
        string[] dados;

        for (int i = 0; i < c; i++)
        {
            dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            int forca = int.Parse(dados[1]);

            if (nome == "Thor")
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
