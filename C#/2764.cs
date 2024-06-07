using System;

class Program
{
    static void Main(string[] args)
    {
       string data = Console.ReadLine();

       DateTime print= DateTime.ParseExact(data,"dd/MM/yy",null);

        string a = print.ToString("MM/dd/yy"); 
        string b = print.ToString("yy/MM/dd"); 
        string c = print.ToString("dd-MM-yy"); 
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
