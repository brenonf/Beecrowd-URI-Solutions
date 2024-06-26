using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int[] n1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] n2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if((decimal)n1[1]/n1[2]<(decimal)n2[1]/n2[2])
        {
            Console.WriteLine(n1[0]);
        }
        else{Console.WriteLine(n2[0]);}


    }
}