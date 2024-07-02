using System;
using System.Linq;

class URI
{
    static void Main()
    {
       int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
       int a = x[0];
       int n=0;
       int soma=0;

       for(int i =1;i<x.Length;i++)
       {
            if(x[i]>0)
            {n =x[i];break;}
       }
       for(int i=0;i<n;i++)
       {
            soma+=a+i;
       }
       Console.WriteLine(soma);
    }
}