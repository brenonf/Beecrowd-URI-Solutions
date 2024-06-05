using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] lista = Console.ReadLine().Split();
        int soma = 0;
        string[] bois = {"Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen"};
        foreach(string i in lista)
        {
            soma+= int.Parse(i);
        }

        if(soma%9==0)
        {Console.WriteLine("Rudolph");}
        else
        {
            Console.WriteLine(bois[soma%9-1]);

        }
    }
}
