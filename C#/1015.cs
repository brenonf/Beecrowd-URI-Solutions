using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] l1= Console.ReadLine().Split(' ');
        string[] l2= Console.ReadLine().Split(' ');
        
        double x1 = double.Parse(l1[0]);
        double x2 = double.Parse(l2[0]);
        double y1 = double.Parse(l1[1]);
        double y2 = double.Parse(l2[1]);
        
        double resultado = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));

        Console.WriteLine("{0:F4}",resultado);
            
        
    }
}