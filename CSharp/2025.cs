using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        string[] frase;

        for (int i = 0; i < n; i++)
        {
            frase = Console.ReadLine().Split();

            for (int j = 0; j < frase.Length; j++)
            {
                if(frase[j].Length >= 10 && frase[j].Contains("oulupukk") && frase[j].Contains("."))
                {
                    frase[j] = "Joulupukki.";
                }
                else if(frase[j].Length >= 10 && frase[j].Contains("oulupukk"))
                {
                    frase[j] = "Joulupukki";
                }
            }
            Console.WriteLine(string.Join(" ", frase));
        }

    }
}
