using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int[] tiro;
        int tiros;
        string pulos;
        char[] acoes;
        int cont=0;
        int n = int.Parse(Console.ReadLine());
        for(int i =0;i<n;i++)
        {
           tiros= int.Parse(Console.ReadLine());
           tiro = Console.ReadLine().Split().Select(int.Parse).ToArray();
           acoes = Console.ReadLine().ToCharArray();
            for(int j =0;j<tiros;j++)
            {
                if(tiro[j]<=2 && acoes[j]=='S')
                {
                    cont++;
                }
                else if(tiro[j]>2 && acoes[j]=='J')
                {cont++;}
            }
            Console.WriteLine(cont);
            cont=0;
        }
    }
}