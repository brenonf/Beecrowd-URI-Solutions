using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i =0;i<10;i++)
        {
            Console.WriteLine($"N[{i}] = {n}");
            n*=2;
        }
    }
}
