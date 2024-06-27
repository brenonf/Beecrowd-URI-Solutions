using System;
using System.Linq;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] x;
        int soma=0;

        for(int i=0; i<n; i++)
        {
            x= Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(x[0]%2!=0)
            {
                Console.WriteLine(x[1]*(x[0]+x[1]-1));
            }
            else{Console.WriteLine(x[1]*(x[0]+x[1]));}
        }
    }
}
