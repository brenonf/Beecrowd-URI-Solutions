using System;
using System.Linq;

class Program 
{
    static void Main() 
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int zero = x.Count(a =>a==0);

        if((decimal)zero>(decimal)n/2m)
        {
            Console.WriteLine("Y");
        }
        else{Console.WriteLine("N");}
        


    }
        
}