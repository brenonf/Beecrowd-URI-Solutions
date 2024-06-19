using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        int[] n;
        int[] lista;
        bool yes=false;
        while (true)
        {
            n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0)
            {break;}
            int[] alunos = new int[n[0]];
            for(int i =0;i<n[1];i++)
            {
                lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j=0;j<lista.Length;j++)
                {
                    alunos[j] +=lista[j];
                }
            }
            foreach(int i in alunos)
            { 
                if(i==n[1])
                {
                    yes = true;
                }
            }
            if(yes)
            {
                Console.WriteLine("yes");
            }
            else{Console.WriteLine("no");}  
            yes=false;


        }
    }
}