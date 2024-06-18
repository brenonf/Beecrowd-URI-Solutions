using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string x;
        
        for(int i = 0 ; i<n ; i++)
        {
            x = Console.ReadLine();
            Console.WriteLine("resposta {0}: {1}",i+1,x);
        }
    }
}