using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        int n;
        int a50;
        int a10;
        int a5;
        int a1;
        int cont=1;
        while(true)
        {
            n= int.Parse(Console.ReadLine());
            if(n==0)
            {break;}
            a50 = n/50;
            n%=50;

            a10 = n/10;
            n%=10;

            a5 = n/5;
            n%=5;

            a1 = n;
            
            Console.WriteLine($"Teste {cont}");
            Console.WriteLine($"{a50} {a10} {a5} {a1}");
            cont++;
            Console.WriteLine();


        }
    }
}


//B$ 50,00, B$10,00, B$5,00 e B$1,00