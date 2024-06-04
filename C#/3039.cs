using System;



public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int carrinhos =0;
        int bonecas=0;

        for(int i =0;i<n;i++)
        {
            string[] nome = Console.ReadLine().Split();
            if(nome[1]=="M")
            {carrinhos++;}
            else{bonecas++;}

        }
        Console.WriteLine("{0} carrinhos",carrinhos);
        Console.WriteLine("{0} bonecas",bonecas);


        
    }   

}
