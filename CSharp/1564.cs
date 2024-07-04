using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> dilma = new List<int>();
        int cont = 0;

        while (true)
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                dilma.Add(x);
                cont++;
            }
            catch (Exception)
            {
                break;
            }
        }

        foreach (int i in dilma)
        {
            if (i == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }
        }
    }
}
