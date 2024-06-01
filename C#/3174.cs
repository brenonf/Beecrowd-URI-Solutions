using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int n = Convert.ToInt32(Console.ReadLine());
        int bonecos = 0;
        int arquitetos = 0;
        int musicos = 0;
        int desenhistas = 0;
        int soma=0;
        
        for(int i = 0; i < n; i++)
        {
           string[] lista = Console.ReadLine().Split(' ');
           int horas = int.Parse(lista[2]);
           switch (lista[1])
           {
               case "bonecos":
                   bonecos += horas;
                   break;

               case "arquitetos":
                   arquitetos += horas;
                   break;

               case "musicos":
                   musicos += horas;
                   break;

               case "desenhistas":
                   desenhistas += horas;
                   break;
           }
        }
        soma+=Convert.ToInt32(bonecos/8);
        soma+=Convert.ToInt32(arquitetos/4);
        soma+=Convert.ToInt32(musicos/6);
        soma+=Convert.ToInt32(desenhistas/12);
        Console.WriteLine(soma);
    }
}
