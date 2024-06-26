using System;
using System.Linq;
using System.Collections.Generic;

class URI {
    static void Main(string[] args) 
    {
        string input;
        List<string> print = new List<string>();

        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                break;
            }

            if (input.Length == 0)
            {
                Console.WriteLine();
                continue;
            }

            var tratado = new string(input.Where(c => !char.IsWhiteSpace(c)).Distinct().OrderBy(c => c).ToArray());

            if (tratado.Length == 0)
            {
                Console.WriteLine();
                continue;
            }

            char primeira = tratado[0];
            char segunda = tratado[0];

            for (int i = 1; i < tratado.Length; i++)
            {
                if (tratado[i] - segunda == 1)
                {
                    segunda = tratado[i];
                }
                else
                {
                    print.Add($"{primeira}:{segunda}");
                    primeira = tratado[i];
                    segunda = tratado[i];
                }
            }

            print.Add($"{primeira}:{segunda}");

            Console.WriteLine(string.Join(", ", print));
            print.Clear();
        }
    }
}
