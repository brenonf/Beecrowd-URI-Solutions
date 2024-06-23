using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n;
        string nome1;
        string nome2;
        int jogada;
        int cont=0;

        while(true)
        {
            n= int.Parse(Console.ReadLine());
            if( n == 0 )
            {break;}
            cont++;
            nome1 = Console.ReadLine();
            nome2 = Console.ReadLine();
            Console.WriteLine($"Teste {cont}");

            for(int i =0;i<n;i++){
                jogada = Console.ReadLine().Split().Select(int.Parse).ToArray().Sum();
                if(jogada%2==0)
                {Console.WriteLine(nome1);}
                else{Console.WriteLine(nome2);}
            }
            Console.WriteLine();



        }
    }
}
