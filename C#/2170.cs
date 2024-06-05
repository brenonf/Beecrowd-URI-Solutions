using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int cont=1;
        while(true)
        {
        string a = Console.ReadLine();
        if(a==null)
        {break;}
        
        string[] n= a.Split();
        
        decimal x = decimal.Parse(n[0]);
        decimal y = decimal.Parse(n[1]);
        
        decimal total = (y-x)/x;
        
        Console.WriteLine($"Projeto {cont}:");
        Console.WriteLine($"Percentual dos juros da aplicacao: {total*100:F2} %");
        Console.WriteLine("");
        cont++;
        }
    }    
}
