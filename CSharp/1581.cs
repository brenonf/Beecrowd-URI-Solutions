using System;
using System.Collections.Generic;


class Program


{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> lista = new List<string>();
        string aux="";
        int m=0;
        int cont =0;

        for(int i = 0;i<n;i++)
        {   
            m= int.Parse(Console.ReadLine());
            for(int j =0;j<m;j++)
            {
            lista.Add(Console.ReadLine());
            }
            aux=lista[0];
            foreach(string x in lista)
            {
                if(aux!=x)
                {Console.WriteLine("ingles");
                    break;}
                else
                {
                    cont++;
                }

            }
            if(lista.Count ==cont)
            {
                Console.WriteLine(lista[0]);
            }
            cont=0;
            lista.Clear();
        }
    }
}