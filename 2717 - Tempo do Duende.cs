using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int min = int.Parse(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(' ');
        int temp1 = int.Parse(temp[0]);
        int temp2 = int.Parse(temp[1]);

        if (temp1 + temp2 > min)
        {
            Console.WriteLine("Deixa para amanha!");
        }
        else
        {
            Console.WriteLine("Farei hoje!");
        }
    }
}
