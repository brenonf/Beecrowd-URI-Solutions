using System;
using System.Linq;
using System.Text;

class URI 
{
    static void Main(string[] args) 
    {
        StringBuilder print = new StringBuilder();
        char[] n = Console.ReadLine().ToCharArray();
        char[] frase = Console.ReadLine().ToCharArray();

        foreach (char c in frase)
        {
            print.Append(n[(int)c-97]);
        }
        Console.WriteLine(print);
    }
}