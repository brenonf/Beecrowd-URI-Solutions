using System;
using System.Linq;

class URI
{
    static void Main()
    {
        string entrada;
        int n;
        int[] lista;
        int soma=0;
        
       while(true)
       {
            entrada = Console.ReadLine();
            if(string.IsNullOrEmpty(entrada))
            {break;}

            n=int.Parse(entrada);
            lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(lista);

            for (int i = 0;i<n/2;i++)
            {
                soma+= lista[n-1-i]-lista[i];
            }
            Console.WriteLine(soma);
            soma=0;
       }

    }
}
