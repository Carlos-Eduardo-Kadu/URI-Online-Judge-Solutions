using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 2000) { n = int.Parse(Console.ReadLine()); }
        
        string[] nomeCurso = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            nomeCurso[i] = Console.ReadLine();
        }
        Console.WriteLine("Ciencia da Computacao");


    }

}
