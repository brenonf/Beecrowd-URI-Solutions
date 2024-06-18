// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int filtros = 0;
        int buracos=0;
        
        for(int i = 0 ; i<n ; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            
            filtros = Convert.ToInt32(entrada[0]);
            buracos = 0;
            for(int j = 1; j< filtros+1; j++)
            {
                buracos+= Convert.ToInt32(entrada[j])-1;
                //Console.WriteLine(buracos);
            }
            buracos+=1;
            Console.WriteLine(buracos);
        }
        
        //Console.WriteLine(filtros);
    }
}