using System;

class Program
{
    static void Main(string[] args)
    {   
        string d;
        string s;
        while (true)
        {
            d=Console.ReadLine();
            if(string.IsNullOrEmpty(d))
            {break;}
            s=Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {break;}

            if(d.Contains(s))
            {Console.WriteLine("Resistente");}
            else{Console.WriteLine("Nao resistente");}
        }
    }
}