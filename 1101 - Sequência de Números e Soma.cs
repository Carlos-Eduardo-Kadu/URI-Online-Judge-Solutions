using System;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int n1, n2, sum;
            
            while (true)
            {
                numeros = Console.ReadLine().Split(' ');
                n1 = int.Parse(numeros[0]);
                n2 = int.Parse(numeros[1]);
                
               
                if (n1 <= 0 || n2 <= 0)
                    break;
                
               
                if (n1 > n2)
                {
                    int temp = n1;
                    n1 = n2;
                    n2 = temp;
                }
                
                sum = 0;
                string output = "";
                
                for (int i = n1; i <= n2; i++)
                {
                    sum += i;
                    output += i.ToString() + " ";
                }
                
                // Remove o espaço extra no final e adiciona a soma
                output = output.TrimEnd() + " Sum=" + sum;
                Console.WriteLine(output);
            }
        }
    }
}

using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int incre = 0;

            while ((n1 != 0 && n2 != 0) && (n1 > 0 && n2 > 0))
            {
                if(n1 > n2)
                {
                    int temp = n1;
                    n1 = n2;
                    n2 = temp;
                }
                for (int i = n1; i <= n2; i++) 
                {
                    incre = incre + i;
                    Console.Write($"{i} ");
                    
                }
                    Console.Write($"Sum = {incre}");
                    Console.WriteLine();

                numeros = Console.ReadLine().Split(' ');
                n1 = int.Parse(numeros[0]);
                n2 = int.Parse(numeros[1]);
                incre = 0;
            }
        }
    }
}
