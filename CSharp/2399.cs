using System;
using System.Collections.Generic;


class URI 
{

    static void Main(string[] args) 
    { 
        int n =int.Parse(Console.ReadLine());
        int[] listao = new int[n];
        List<int> print = new List<int>();

        for(int i = 0; i < n;i++)
        {
            listao[i] = int.Parse(Console.ReadLine());
        }

        if(n==1)
        {Console.WriteLine(listao[0]);}
        else{
        print.Add(listao[0]+listao[1]);

        for(int i = 1; i < n-1;i++)
        {
            print.Add(listao[i-1]+listao[i]+listao[i+1]);
        }
        print.Add(listao[n-1]+listao[n-2]);

        foreach(int i in print)
        {Console.WriteLine(i);}
        }
    }
}