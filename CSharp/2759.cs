using System;

public class Program
{
    public static void Main(string[] args)
    {
        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();

        Console.WriteLine("A = {0}, B = {1}, C = {2}",x,y,z);
        Console.WriteLine("A = {0}, B = {1}, C = {2}",y,z,x);
        Console.WriteLine("A = {0}, B = {1}, C = {2}",z,x,y);

    }
}
