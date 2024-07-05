using System; 

class URI {

    static void Main(string[] args) { 
        
        int N = int.Parse(Console.ReadLine());
        int r = 0; 

        while (true)
        {
            while (N < 0 || N > 100 ) 
            {
                N = int.Parse(Console.ReadLine());
            }
        
            if (N == 0)
            {
                break;
            }
            
            for (int i = 0; i <= N; i++)
            {
                r += i * i;
            }
            Console.WriteLine(r);
            N = int.Parse(Console.ReadLine());
            r = 0;
        }
    }
}
