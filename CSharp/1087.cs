using System;
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        int[] lista;
        int x;
        int y;
        int a;
        int b;
        List<int> print = new List<int>();
        while(true)
        {
            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            x=lista[0];
            y=lista[1];
            a=lista[2];
            b=lista[3];
            if(a==0 && b==0 && x==0 && y==0)
            {break;}

            if(x==a && y==b)
            {print.Add(0);}
            else if(x==a || y==b || Math.Abs(x-a)==Math.Abs(y-b))
            {print.Add(1);}
            else{print.Add(2);}

            }
            foreach(int p in print)
            {Console.WriteLine(p);}

        }

    }
