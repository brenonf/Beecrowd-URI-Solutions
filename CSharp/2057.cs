using System;
using System.Linq;

class URI
{
    static void Main()
    {
       int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

       int a = x[0];
       int b = x[1];
       int c = x[2];

       int hora =a+b;

       if(hora>=24)
       {hora-=24;}

        hora+=c;

        if(hora>=24)
        {hora-=24;}
        else if(hora<0)
        {
            hora= 24+hora;
        }
        Console.WriteLine(hora);

    }
}
