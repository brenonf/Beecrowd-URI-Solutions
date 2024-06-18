using System;
using System.Collections.Generic;

class URI {
    static void Main(string[] args) 
    {

        int n =int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> x = new Dictionary<string, List<string>> 
        {
            {"tesoura", new List<string> {"papel", "lagarto"}},
            {"papel", new List<string> {"pedra", "spock"}},
            {"pedra", new List<string> {"lagarto", "tesoura"}},
            {"lagarto", new List<string> {"spock", "papel"}},
            {"spock", new List<string> {"tesoura", "pedra"}}
            };

        for(int i = 0; i < n; i++) 
        {
             string[] entrada = Console.ReadLine().Split(' ');
            string ra = entrada[0];
            string sh = entrada[1];

            if (ra== sh ) 
            {
                Console.WriteLine("empate");

            } 
            else if (x[ra].Contains(sh)) {
                Console.WriteLine("rajesh");
            } 
            else 
            {
            Console.WriteLine("sheldon");
            }
        }
    }
}
