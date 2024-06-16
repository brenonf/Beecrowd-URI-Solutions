using System;
using System.Linq;

class Program
{
    static void Main()
    {  
        string a;
        char[] lista;
        int n;
        int soma=0;
        int somaR=0;

        while(true)
        {
        a=Console.ReadLine();
        if(string.IsNullOrEmpty(a))
        {break;}
        lista=a.ToCharArray();
        n = int.Parse(Console.ReadLine());

        for(int i=0;i<lista.Length;i++)
        {
            if(lista[i] == 'R' && somaR+1<n)
            {   
                somaR++;
            }
            else if(lista[i]=='R' && somaR+1==n)
            {
                
                soma++;
                somaR=0;
            }
            else if(lista[i]=='W' )
            {
                soma++;
                if(i>0 && lista[i-1]=='R'&& somaR>0)
                    {
                    somaR=0;
                    soma++;
                    }
            }
        }
        if(somaR>0)
        {soma++;}
        Console.WriteLine(soma);
        soma=0;
        somaR=0;
        }
    }
}
