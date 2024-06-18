using System;



public class Program
{
    public static void Main(string[] args)
    {
        string[] n = Console.ReadLine().Split();
        int e = int.Parse(n[0]);
        int f = int.Parse(n[1]);
        int c = int.Parse(n[2]);
        int g =0;
        int cont= 0;
        e=e+f;

        while((e)/c!=0)
        {
            g= (e)/c;
            //Console.WriteLine(e/c);
            e = e%c +g;
            cont+=g;
            g=g%c;
        }
        Console.WriteLine(cont);




    }   

}
