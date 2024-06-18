using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        string teste = "aaaa";
        int cont;
        
        while (teste != null)
        {   
            cont=0;
            teste = Console.ReadLine();
            if (teste==null)
            {
                break;
            }
            string[] lista = teste.Split();
            int x = Convert.ToInt32(lista[0]);
            int y = Convert.ToInt32(lista[1]);
            int z = Convert.ToInt32(lista[2]);
            
            for(int i =0 ; i< x; i++)
            {   
                int  w =Convert.ToInt32(Console.ReadLine());
                if (w >= y && w<= z)
                {cont+=1;}
            }
            Console.WriteLine(cont);
        }
        
    }
}