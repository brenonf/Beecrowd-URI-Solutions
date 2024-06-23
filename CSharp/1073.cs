using System; 

class URI {

    static void Main(string[] args) 
    {
        int a = int.Parse(Console.ReadLine());
        
        for(int i = 2; i <= a; i+=2)
        {
            Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
        }
    }

}