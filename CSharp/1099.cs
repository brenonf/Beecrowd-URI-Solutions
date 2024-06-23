using System;
using System.Linq;


class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int[] x;
        int soma =0;

        for(int i = 0; i < n;i++)
        {
            x = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(x);

            if(x[0]==x[1])
            {soma=0;}
            else
            {
                for(int j=x[0]+1;j<x[1];j++)
                {
                    if(j%2!=0)
                    {soma+=j;}
                }
            }
            Console.WriteLine(soma);
            soma=0;

        }
    }

}

