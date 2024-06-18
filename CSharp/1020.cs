using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int y = a/365;
        int m = (a%365)/30;
        int d= ((a%365)%30);
    Console.WriteLine($"{y} ano(s)");
    Console.WriteLine($"{m} mes(es)");
    Console.WriteLine($"{d} dia(s)");


        
    }
}
