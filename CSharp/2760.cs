using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        Console.WriteLine(a+b+c);
        Console.WriteLine(b+c+a);
        Console.WriteLine(c+a+b);
        
        if (a.Length>10)
            {a=a.Substring(0, 10);}
        if (b.Length>10)
            {b=b.Substring(0, 10);}
        if (c.Length>10)
            {c=c.Substring(0, 10);}
        
        Console.WriteLine(a+b+c);
        



        
    }
}