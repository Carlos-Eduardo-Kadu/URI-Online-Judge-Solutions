using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int X = int.Parse(input[0]);
        int Y = int.Parse(input[1]);

        StringBuilder output = new StringBuilder();
        int count = 0;

        for (int i = 1; i <= Y; i++)
        {
            output.Append(i);
            count++;

            if (i != Y)
            {
                if (count % X == 0)
                    output.AppendLine();
                else
                    output.Append(" ");
            }
        }

        Console.WriteLine(output.ToString());
    }
}
