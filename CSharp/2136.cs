using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        string amigo="";
        int tamanho=0;
        string[] teste;
        List<string> sim = new List<string>();
        List<string>nao = new List<string>();

        while(true)
        {
            teste = Console.ReadLine().Split();
            if(teste[0]=="FIM")
            {break;}
            else if(teste[1]=="YES")
            {
                sim.Add(teste[0]);
                if(teste[0].Length>tamanho)
                {amigo=teste[0];
                tamanho=teste[0].Length;}
            }
            else if(teste[1]=="NO")
            {
                nao.Add(teste[0]);
            }
        }

        sim = sim.Distinct().OrderBy(s => s).ToList();
        nao = nao.Distinct().OrderBy(n => n).ToList();
        foreach(string s in sim)
        {
            Console.WriteLine(s);
            
        }
        foreach(string n in nao)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("");
        Console.WriteLine("Amigo do Habay:");
        Console.WriteLine(amigo);
    
    }

}