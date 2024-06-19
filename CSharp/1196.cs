using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        char[] letras="`1234567890-=QWERTYUIOP[]\\ASDFGHJKL;'ZXCVBNM,./".ToCharArray();
        int indice=0;
        string x;
        while(true)
        {
            x=Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
        char[] frase=x.ToCharArray();

        for(int i=0;i<frase.Length;i++)
        {
            indice = Array.IndexOf(letras,frase[i]);
            
            if(indice!=-1)
            {
            frase[i]=letras[indice-1];
            }
        }
        Console.WriteLine(string.Join("",frase));
    }}
}