using System;

class URI
{
    static void Main()
    {
        int n;
        int soma=0;
        int cont=0;

        while(true)
        {
            n= int.Parse(Console.ReadLine());
            if(n==0)
            {break;}

            while(cont!=5)
            {
                if(n%2==0)
                {
                    cont++;
                    soma+=n;
                }
                n++;
            }
            Console.WriteLine(soma);
            soma=0;
            cont=0;
        }
    }        
}
