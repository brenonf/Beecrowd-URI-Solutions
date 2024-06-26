using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int somaAldo = 0;
        int somaBeto = 0;
        int n;
        int[] entrada;
        int cont = 1;

        while(true)
        {
            n = int.Parse(Console.ReadLine());
            if(n == 0)
            {break;}

            for(int i=0;i<n;i++){
                entrada = Console.ReadLine().Split().Select(int.Parse).ToArray();
                somaAldo += entrada[0];
                somaBeto += entrada[1];
            }
                            Console.WriteLine($"Teste {cont}");

            if(somaAldo>somaBeto)
            {
                Console.WriteLine($"Aldo");
            }
            else{Console.WriteLine($"Beto");}
            Console.WriteLine();
            somaAldo=0;
            somaBeto=0;
            cont++;
        }

    }
}