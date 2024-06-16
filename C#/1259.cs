using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int n = int.Parse(Console.ReadLine());
        List<int> par = new List<int>();
        List<int> impar = new List<int>();
        int a;

        for(int i = 0; i < n;i++)
        {
            a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {par.Add(a);}
            else
            {impar.Add(a);}
        }  
        par.Sort();
        impar.Sort();
        impar.Reverse();
        foreach(int x in par)
        {Console.WriteLine(x);}
        foreach(int x in impar)
        {Console.WriteLine(x);}
    }
}
