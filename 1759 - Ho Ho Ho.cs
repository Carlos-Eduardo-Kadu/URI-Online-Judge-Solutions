using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string text = "";
        
        for(int i = 1; i <= n; i++)
        {
            if(i < n)
            {
                text = text + "Ho ";
            }
            else
            {
                text = text + "Ho!";
            }
        }
        Console.WriteLine(text);
    }
}
