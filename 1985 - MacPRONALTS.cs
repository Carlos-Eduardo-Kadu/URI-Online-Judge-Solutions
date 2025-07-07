using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int p, c, qtd;
        double preco = 0, precoTotal = 0;
        p = int.Parse(Console.ReadLine());
        while (p > 5 || p < 1)
        {
            p = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < p; i++)
        {
            string[] codQtd = Console.ReadLine().Split(' ');
            c = int.Parse(codQtd[0]);
            qtd = int.Parse(codQtd[1]);
            switch (c)
            {
                case 1001:
                    preco = qtd * 1.50;
                    break;
                case 1002:
                    preco = qtd * 2.50;
                    break;
                case 1003:
                    preco = qtd * 3.50;
                    break;
                case 1004:
                    preco = qtd * 4.50;
                    break;
                case 1005:
                    preco = qtd * 5.50;
                    break;
            }
            precoTotal = precoTotal + preco;
        }
        Console.WriteLine(precoTotal.ToString("F2", CultureInfo.InvariantCulture));
    }
}
