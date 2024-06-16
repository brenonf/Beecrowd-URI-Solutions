using System;
using System.Linq;

class Program
{
    static void Main()
    {      
        int n;
        string[] nome;
        string[] chamada;
        int P =0;
        int F =0;
        string print="";

        int t = int.Parse(Console.ReadLine());

        for(int k=0; k<t; k++)
        {

        n =int.Parse(Console.ReadLine());

         nome=Console.ReadLine().Split();

         chamada=Console.ReadLine().Split();

         for(int i=0;i<nome.Length;i++)
         {
            for(int j=0;j<chamada[i].Length;j++)
            {
                if(chamada[i][j]=='P')
                {
                    P++;
                }
                else if(chamada[i][j]=='A')
                {
                    F++;
                }
            }
            
            if((decimal)P/(decimal)(P+F)<0.75m)
            {
                print+=nome[i]+" ";
            }
            P=0;
            F=0;
            
         }
         Console.WriteLine(print.TrimEnd());
         print="";
        }
    }
}