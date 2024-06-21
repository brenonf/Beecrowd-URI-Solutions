using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n;
        int cont=1;
        
        while(true)
        {
            n=int.Parse(Console.ReadLine());
            if(n == 0)
            {break;}
            int[] listao= Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i =0; i < n; i++)
            {
                if(i+1==listao[i])
                {
                    Console.WriteLine($"Teste {cont}");
                    Console.WriteLine(i+1);
                    Console.WriteLine();
                    cont++;
                    break;
                }
            }

        }
    }
}