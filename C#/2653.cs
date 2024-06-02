using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        HashSet<string> conjunto = new HashSet<string>();
        string aux="";
        
        while(aux != null)
        {
            aux = Console.ReadLine();
            if(aux==null)
            {break;}
            conjunto.Add(aux);
        }
        Console.WriteLine(conjunto.Count);
    }
}
