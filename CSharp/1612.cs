using System;

class URI
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal tronco;

        for(int i =0;i<n;i++)
        {
            tronco = decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(tronco/2));

        }
    }
}

