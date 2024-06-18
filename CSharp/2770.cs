using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   while(true)
        {
            string bora =Console.ReadLine();
            if(bora==null)
            {break;}

            string[] lista = bora.Split();
            int x = int.Parse(lista[0]);
            int y = int.Parse(lista[1]);
            int z = int.Parse(lista[2]);
            
            int[] lista2 = new int[2];
            lista2[0] =x;
            lista2[1]=y;
            Array.Sort(lista2);
            
            for(int i =0; i<z;i++)
            {
                string[] lista3 = Console.ReadLine().Split();
                int a = int.Parse(lista3[0]);
                int b = int.Parse(lista3[1]);
                
                if(a>=b)
                {
                    if(lista2[1]>=a && lista2[0]>=b)
                    {Console.WriteLine("Sim");}
                    else
                    {Console.WriteLine("Nao");}
                }
                else
                {
                    if(lista2[1]>=b && lista2[0]>=a)
                    {Console.WriteLine("Sim");}
                    else
                    {Console.WriteLine("Nao");}
                }
            }
        }
        
    }
}