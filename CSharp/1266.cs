using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n;
        int[] lista;
        int estacas=0;
        int estacas2=0;

        int cont=0;

        while(true)
        {
            n=int.Parse(Console.ReadLine());
            if(n == 0)
            {break;}

            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lista2 = new int[n];

            Array.Copy(lista, lista2, n);
            Array.Reverse(lista2);

            for(int i=0;i<n;i++)
            {
                if(lista[i]==0)
                {cont++;}
                else if(lista[i]==1)
                {cont=0;}

                if(cont>=2)
                {cont=0;estacas++;lista[i]=1;}
            }
            if(lista[0]==0)
                {cont++;}
            else if(lista[0]==1)
                {cont=0;}

            if(cont>=2)
                {cont=0;estacas++;}

            cont=0;
            for(int i=0;i<n;i++)
            {
                if(lista2[i]==0)
                {cont++;}
                else if(lista2[i]==1)
                {cont=0;}

                if(cont>=2)
                {cont=0;estacas2++;lista2[i]=1;}
            }
            if(lista2[0]==0)
                {cont++;}
            else if(lista2[0]==1)
                {cont=0;}

            if(cont>=2)
                {cont=0;estacas2++;}
            Console.WriteLine(Math.Min(estacas,estacas2));
            estacas=0;
            cont=0;
            estacas2=0;
            

        }
    }
}