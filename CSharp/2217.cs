using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i=0;i<n;i++)
        {
            long N = long.Parse(Console.ReadLine());
            int gambiarra = (N%2 == 0)?1:9;
            Console.WriteLine(gambiarra);
        }
    }
}
