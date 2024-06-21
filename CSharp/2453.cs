using System;

class URI
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        n=n.Replace("pp","-");
        n=n.Replace("pP","+");
        n=n.Replace("p","");
        n=n.Replace("-","p");
        n=n.Replace("+","P");
        Console.WriteLine(n);
    }
}