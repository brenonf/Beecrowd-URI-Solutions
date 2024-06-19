using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int m =1;
        int removido=0;
        while(true)
        {
        int n = int.Parse(Console.ReadLine());
        if(n==0)
        {break;}
        Queue<int> fila = new Queue<int>(Enumerable.Range(1,n));

            while(true)
            {   
                removido=fila.Dequeue();
                if(removido==13 && fila.Count==0)
                {break;}
                else if(fila.Count==0)
                {
                    fila = new Queue<int>(Enumerable.Range(1,n));
                    m++;
                    removido=0;
                    continue;
                }
                for(int i=0;i<m-1;i++)
                {
                   fila.Enqueue(fila.Dequeue());
                }
                
            }
        Console.WriteLine(m);
        fila = new Queue<int>(Enumerable.Range(1,n));
        m=1;
        removido=0;


    }
    }
}