using System;
using System.Linq;


class URI 
{

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());

        for(int i=0; i<n;i++)
        {   
            int soma=0;
            Console.ReadLine();
            int[] lista=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lista2 =new int[lista.Length];

            Array.Copy(lista,lista2,lista.Length);

            Array.Sort(lista);
            Array.Reverse(lista);

            for(int j =0;j<lista.Length;j++)
            {
                if(lista[j]-lista2[j]==0)
                {
                   soma+=1; 
                }
            }
            Console.WriteLine(soma);
            soma=0;


        }
    }

        
}







