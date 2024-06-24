using System;

class URI
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if(x>y)
        {
            int aux=y;
            y=x;
            x=aux;
        }
        x++;
        while(x%5!=0 && x<y)
        {
            if(x%5==2 || x%5==3)
            {
                Console.WriteLine(x);
            }
            x++;
            if(x>=y)
            {break;}
        }

        while(x<y)
        {
            x+=2;
            if(x>=y)
            {break;}
            Console.WriteLine(x);
            x+=1;
            if(x>=y)
            {break;}
            Console.WriteLine(x);
            x+=2;
            if(x>=y)
            {break;}
        }

    }
}


//é possível tb via força bruta, varrendo tudo e validando um a um no intervalo.