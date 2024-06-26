using System;
using System.Text;
class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder print = new StringBuilder("Ent");
        
        print.Append('a', n);
        print.Append("o eh N");
        print.Append('a', n);
        print.Append("t");
        print.Append('a', n);
        print.Append("l!");
        Console.WriteLine(print.ToString());

    }
}
