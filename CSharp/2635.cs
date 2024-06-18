using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {   
        string tresh;
        string tresp;
        int n = int.Parse(Console.ReadLine());
        string[] hist = new string[n];
        
        int soma=0;
        int caracteres=0;

        for(int i=0;i<n;i++)
        {
            hist[i]= Console.ReadLine();
        }
        int m = int.Parse(Console.ReadLine());
        string[] pesq = new string[m];

        for(int i=0;i<m;i++)
        {
            pesq[i]= Console.ReadLine();
        }

        foreach(string i in pesq)
        {   
            
            foreach(string j in hist)
            {
                if(i.Length<=j.Length)
                {
                tresh = j.Substring(0,i.Length);
                if(tresh==i)
                {
                    soma++;
                    if(caracteres< j.Length)
                    {
                        caracteres=j.Length;
                    }
                }
                }
                

            }
            if(soma==0)
            {Console.WriteLine(-1);}
            else
            {
            Console.WriteLine($"{soma} {caracteres}");
            }
            soma=0;
            caracteres=0;
        }
    }
}

