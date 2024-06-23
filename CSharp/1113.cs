using System;
using System.Linq;

class URI
{
    static void Main()
    {
        int[] x;

        while(true)
        {
            x = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(x[0]>x[1])
            {Console.WriteLine("Decrescente");}
            else if(x[1]>x[0])
            {Console.WriteLine("Crescente");}
            else{break;}
        }
    }
}
