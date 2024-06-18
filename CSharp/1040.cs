using System;
using System.Linq;
using System.Globalization;

class Program {
    static void Main() 
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal[] x = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        decimal media = Math.Floor((x[0] * 2 + x[1] * 3 + x[2] * 4 + x[3] * 1) / 10m * 10) / 10; 
        Console.WriteLine($"Media: {media:F1}");
        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            decimal notaExame = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {notaExame:F1}");
            decimal mediaFinal = (notaExame + media) / 2;
            if (mediaFinal >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {mediaFinal:F1}");
            
        }
    }
}
