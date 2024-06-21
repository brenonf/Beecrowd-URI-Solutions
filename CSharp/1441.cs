using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        int n;
        while(true)
        {
            n = int.Parse(Console.ReadLine());
            List<int> listao = new List<int>();
            
            if(n==0)
            {break;}
            listao.Add(n);
            while(n!=1)
            {
                if(n%2==0)
                {
                    n = n/2;
                }
                else{n=3*n+1;}
                listao.Add(n);
            }
            Console.WriteLine(listao.Max());
            listao.Clear();
        }
    }
}