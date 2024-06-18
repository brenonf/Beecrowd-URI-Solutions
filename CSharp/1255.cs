using System;
using System.Linq;
using System.Collections.Generic;

class Program


{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string a="";
        int[] alfa = new int[26];
        int maior=0;
        List<char> lista = new List<char>();

        for(int i =0;i<n;i++)
        {
            
            a=Console.ReadLine().ToLower();
            foreach(char c in a)
            {
                if(char.IsLower(c))
                {
                alfa[(int)c-97]+=1;
                }
            }

            maior =alfa.Max();

            for(int j=0;j<26;j++)
            {
                if(alfa[j]==maior)
                {
                    lista.Add((char)(j+97));
                }
            }

            foreach(char ch in lista)
            {Console.Write(ch);}
            Console.Write("\n");
            lista.Clear();

            for (int k = 0; k < alfa.Length; k++)
                {   
                    alfa[k] = 0;
                }

            
            
        }
    }
}
        