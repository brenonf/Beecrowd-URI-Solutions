using System; 
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());
        string a;
        HashSet<string> poke = new HashSet<string>();

        for(int i = 0; i < n;i++)
        {
            a = Console.ReadLine();
            poke.Add(a);
        }
        Console.WriteLine($"Falta(m) {151-poke.Count} pomekon(s).");


    }
}