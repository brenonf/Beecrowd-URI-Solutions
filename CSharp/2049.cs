using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int cont=0;
        string a;
        string b;

        while(true)
        {
            a = Console.ReadLine();
            if(a=="0")
            {break;}
            if(cont>0)
            {Console.WriteLine();}
            cont++;

            b=Console.ReadLine();

            Console.WriteLine($"Instancia {cont}");
            if(b.Contains(a))
            {
                Console.WriteLine("verdadeira");
            }
            else{Console.WriteLine("falsa");}
        }

    }
}