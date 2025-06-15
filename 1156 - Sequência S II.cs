using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 1.0, n = 3.0, d = 2.0;

           for(int i = 1; i <= 100; i++)
           {
                s += n / d;

                n = n + 2.0;
                d = d * 2.0;

           }
           Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
