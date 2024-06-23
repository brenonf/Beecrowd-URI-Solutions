using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n;
        int[] lista;
        int t=10;   
        int contagemRegressiva=0;

        while(true)
        {
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {break;}
            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(lista.Length == 1)
            {Console.WriteLine(10);}
            else
            {
                for(int i =0;i<n-1;i++)
                {
                    if(lista[i+1]-lista[i]<10)
                    {
                        t+=lista[i+1]-lista[i];
                    }
                    else{t +=10;}
                }
                Console.WriteLine(t);
                t=10;
            }

        }
    }
}
