using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        string[] x = Console.ReadLine().Split();
        int n = int.Parse(x[0]);
        int c = int.Parse(x[1]);
        int m = int.Parse(x[2]);
        int cont = c;
        
        string[] y =Console.ReadLine().Split();

        string[] z =Console.ReadLine().Split();

        for(int i = 0; i<c;i++)
        {
            if(z.Contains(y[i]))
            {
                cont-=1;
            }
        }
        Console.WriteLine(cont);
    }
}
