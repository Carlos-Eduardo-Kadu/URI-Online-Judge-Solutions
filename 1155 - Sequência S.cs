using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double s = 0;

           for(int i = 1; i <= 100; i++)
           {
                s += 1.0 / i;
           }
           Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
