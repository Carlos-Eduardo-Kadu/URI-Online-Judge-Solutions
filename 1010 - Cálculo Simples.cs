using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1, c2, n1, n2;
            double valorUniUM, valorUniDois, preco1, preco2, valorPagar;
            
            string[] pecaUm = Console.ReadLine().Split(' ');
            string[] pecaDois = Console.ReadLine().Split(' ');

            c1 = int.Parse(pecaUm[0]);
            n1 = int.Parse(pecaUm[1]);
            valorUniUM = double.Parse(pecaUm[2],CultureInfo.InvariantCulture);
            preco1 = n1 * valorUniUM;

            c2 = int.Parse(pecaDois[0]);
            n2 = int.Parse(pecaDois[1]);
            valorUniDois = double.Parse(pecaDois[2],CultureInfo.InvariantCulture);
            preco2 = n2 * valorUniDois;

            valorPagar = preco1 + preco2;

            Console.WriteLine("VALOR A PAGAR: R$ "+ valorPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
