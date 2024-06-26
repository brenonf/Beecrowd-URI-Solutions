using System;
using System.Linq;

class URI
{
    static void Main()
    {
        int n;
        int[] lista;
        int jao=0;
        int zezim=0;
        int cont=0;

       while(true)
       {
            n = int.Parse(Console.ReadLine());
            if(n==0)
            {
                break;
            }
            cont++;
            Console.WriteLine($"Teste {cont}");
            for(int i =0;i<n;i++)
            {
                lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jao+=lista[0];
                zezim+=lista[1];
                Console.WriteLine(jao-zezim);
            }
            Console.WriteLine();
            jao=0;
            zezim=0;
       }

    }
}
