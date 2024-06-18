using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string a;
        while (true)
        {
            a = Console.ReadLine();
            if (string.IsNullOrEmpty(a)) 
            {
                break;
            }

            if (a.Count(char.IsLower) >= 1 &&
                a.Count(char.IsUpper) >= 1 &&
                a.Count(char.IsDigit) >= 1 &&
                Regex.Matches(a, @"\W").Count == 0 &&
                a.Length >= 6 &&
                a.Length <= 32)
            {
                Console.WriteLine("Senha valida.");
            }
            else
            {
                Console.WriteLine("Senha invalida.");
            }
        }
    }
}
