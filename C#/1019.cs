using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int h = a/3600;
        int m = (a%3600)/60;
        int s= ((a%3600)%60);
    Console.WriteLine($"{h}:{m}:{s}");

        
    }
}
