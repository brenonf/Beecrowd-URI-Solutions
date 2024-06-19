using System;

class Program
{
    static void Main(string[] args)
    {   
        int[] lista = new int[] {40320, 5040, 720, 120, 24, 6, 2, 1};

        int n = int.Parse(Console.ReadLine());
        int cont=0;

        foreach(int i in lista)
        {
            cont += n/i;
            n%=i;
        }
        Console.WriteLine(cont);
    }
}
        