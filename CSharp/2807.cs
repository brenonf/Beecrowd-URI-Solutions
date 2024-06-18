using System;


public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] lista = new int[n];

        if(n>=3)
        {
            lista[0] = 1;
            lista[1]= 1;
        for(int i=2 ;i<n; i++)
            {
                lista[i]=lista[i-1]+ lista[i-2];
                
            }
        Array.Reverse(lista);
            for(int i=0;i<n-1;i++)
            {Console.Write("{0} ",lista[i]);}
            Console.WriteLine("1");
            
        }
        else if(n==2)
        {Console.WriteLine("1 1");}
        else
        {{Console.WriteLine("1");}}

    }   

}
