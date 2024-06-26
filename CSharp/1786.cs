using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        string n;
        int soma=0;
        int b1;
        int b2;
        int[] a;
        int cont = 0;

        while(true)
        {
            n = Console.ReadLine();
            if(string.IsNullOrEmpty(n))
            {break;}

            a = n.ToCharArray().Select(x=>int.Parse(x.ToString())).ToArray();

            
            foreach(int x in a)
            {
                cont++;
                soma += x * cont;
            }
            b1=soma%11;
            if(b1==10)
            {b1=0;}
            soma=0;


            foreach(int x in a)
            {
                soma += x * cont;
                cont--;
            }
            b2=soma%11;
            if(b2==10)
            {b2=0;}

            soma=0;

            Console.WriteLine($"{a[0]}{a[1]}{a[2]}.{a[3]}{a[4]}{a[5]}.{a[6]}{a[7]}{a[8]}-{b1}{b2}");
        }


    }
}
        