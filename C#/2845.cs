using System;
using System.Linq;



class URI {

    static void Main(string[] args) 
    { 
      int duende=0;
      int soma=0;

      int n=int.Parse(Console.ReadLine());


      int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();

      duende = lista.Max()+1;

      while(true)
      {
        foreach(int i in lista)
        {
        if(SaoCoprimos(duende,i))
        {
            soma+=1;
        }
        

        }
        if(soma==n)
        {
            break;
        }
        else{soma=0;}
      }
    Console.WriteLine(duende);

       
    }

     static int MDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static bool SaoCoprimos(int a, int b)
    {
        return MDC(a, b) == 1;
    }
}
