using System;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        char[] numeros = Console.ReadLine().ToCharArray();
        int len = numeros.Length;
        int soma=0;
        int qtd=0;
        for(int i=0;i<len;i++)
        {
            if(numeros[i]=='1' && len-1>=i+1 && numeros[i+1]=='0')
            {
                soma+=10;
                qtd++;
            }
            else
            {
                soma+=int.Parse(numeros[i].ToString());
                if(numeros[i]!='0'){
                qtd++;}
            }
        }
        Console.WriteLine($"{(decimal)soma/qtd:F2}");
    }
}
