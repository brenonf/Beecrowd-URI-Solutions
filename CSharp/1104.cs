using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] n;
        HashSet<int> alice;
        HashSet<int> bia;
        


        while(true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {break;}
            alice = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
            bia = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            HashSet<int> difA = new HashSet<int>(alice);
            HashSet<int> difB =new HashSet<int>(bia);

            difA.ExceptWith(bia);
            difB.ExceptWith(alice);

            if(difA.Count <=difB.Count)
            {Console.WriteLine(difA.Count);}
            else
            {
                {Console.WriteLine(difB.Count);}
            }

        }
    }
}