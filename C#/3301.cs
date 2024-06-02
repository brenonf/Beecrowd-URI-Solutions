
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] patos = new int[3];
        string[] pato = Console.ReadLine().Split(' ');
        //int cont = 0;
        
        for(int i = 0 ; i <3 ; i++)
        {
            patos[i]=Convert.ToInt32(pato[i]);
        }
        
        if((patos[0]> patos[1] && patos[0]< patos[2]) || (patos[0]< patos[1] && patos[0]> patos[2]) )
        {
            Console.WriteLine("huguinho");
        }
        
        else if((patos[1]> patos[0] && patos[1]< patos[2]) || (patos[1]< patos[0] && patos[1]> patos[2]) )
        {
            Console.WriteLine("zezinho");
        }
      
        else
        {
            Console.WriteLine("luisinho");
        }
        
        //Console.WriteLine(filtros);
    }
}