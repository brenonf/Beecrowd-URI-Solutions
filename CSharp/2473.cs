using System; 
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        HashSet<int> aposta = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
        HashSet<int> resultado = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

        aposta.IntersectWith(resultado);
        int cont = aposta.Count();

        if(cont<3)
        {Console.WriteLine("azar");}
        else if(cont==3)
        {Console.WriteLine("terno");}
        else if(cont==4)
        {Console.WriteLine("quadra");}
        else if(cont==5)
        {Console.WriteLine("quina");}
        else{Console.WriteLine("sena");}
    }
}