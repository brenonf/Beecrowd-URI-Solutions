using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a1 = int.Parse(Console.ReadLine());
        int a2 = int.Parse(Console.ReadLine());
        int a3 = int.Parse(Console.ReadLine());

        int t1= a2 * 1+ a3*2; 
        int t2= a1* 1+ a3 * 1; 
        int t3=a1 * 2 + a2 * 1; 

        int tf=Math.Min(t1,Math.Min(t2, t3));

        Console.WriteLine(tf*2);
    }
}
