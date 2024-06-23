using System;

class URI
{
    static void Main()
    {
        int[] x = new int[20];

        for(int i =0;i<20;i++)
        {
            x[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(x);
        for(int i=0;i<20;i++)
        {Console.WriteLine($"N[{i}] = {x[i]}");}
    }
}
