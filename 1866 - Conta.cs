using System;

class URI
{

    static void Main(string[] args)
    {
        int C = int.Parse(Console.ReadLine());
        int S;
        int num = 0;
        for (int i = 0; i < C; i++)
        {
            S = int.Parse(Console.ReadLine());
            for (int j = 0; j < S; j++)
            {
                if (num == 0)
                {
                    num++;
                }
                else if (num == 1)
                {
                    num--;
                }
            }
            Console.WriteLine(num);
            num = 0;
        }

    }

}
