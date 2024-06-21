using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {   
        int[] n;
        while (true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0 && n[2]==0)
            {
                break;
            }
            Console.WriteLine((int)Math.Pow(n[0]*n[1]*n[2],((double)1/3)));
        }

    }
}