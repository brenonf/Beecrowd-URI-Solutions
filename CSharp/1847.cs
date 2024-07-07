using System;

class URI
{
    static void Main()
    {
        var x = Console.ReadLine().Split();
        int a = int.Parse(x[0]);
        int b = int.Parse(x[1]);
        int c = int.Parse(x[2]);
        Cara(a,b,c);
    }

    
    static void Cara(int a,int b,int c)
    {
        
        if (a > b && b <= c)
        {
            Console.WriteLine(":)");
        }
        
        else if (a < b && b >= c)
        {
            Console.WriteLine(":(");
        }
        
        else if (a < b && b < c && (b - a) > (c - b))
        {
            Console.WriteLine(":(");
        }
        
        else if (a < b && b < c && (b - a) <= (c - b))
        {
            Console.WriteLine(":)");
        }
        
        else if (a > b && b > c && (a - b) > (b - c))
        {
            Console.WriteLine(":)");
        }
        
        else if (a > b && b > c && (a - b) <= (b - c))
        {
            Console.WriteLine(":(");
        }
        
        else if (a == b && b < c)
        {
            Console.WriteLine(":)");
        }
        
        else if (a == b && b > c)
        {
            Console.WriteLine(":(");
        }
        else if (a == b && b == c)
        {
            Console.WriteLine(":(");
        }
    }
}
