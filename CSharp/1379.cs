using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        string n;
        int[] lista;

        while(true)
        {
            n=Console.ReadLine();
            if(n=="0 0")
            {break;}

            lista = n.Split().Select(int.Parse).ToArray();
            
            
            
            Console.WriteLine(2*lista[0]-lista[1]);

        }
    }

}   

/*
m=a+b/2
2*m=a+b
2*m-b=a

*/