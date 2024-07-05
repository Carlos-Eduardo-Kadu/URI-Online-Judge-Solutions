int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

for (int i = 0; i < y; i++)
{
    Console.Write(i);

    if (i % x == 0)
    {
        Console.WriteLine("");
    }
    else
    {
        Console.Write(" ");
    }
}
