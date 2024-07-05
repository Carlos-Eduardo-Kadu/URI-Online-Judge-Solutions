using System; 

class URI {

    static void Main(string[] args) { 
            string data = Console.ReadLine();
            
            string dd = data.Substring(0,2);
            string mm = data.Substring(3,3-1);
            string yy = data.Substring(6);
            
            
            string d1 = mm + "/" + dd + "/" + yy;
            string d2 = yy + "/" + mm + "/" + dd;
            string d3 = dd + "-" + mm + "-" + yy;
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
    }

}
