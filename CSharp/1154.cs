using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        List<int> idades = new List<int>();
        int idade;

        while (true)
        {
            idade=int.Parse(Console.ReadLine());
            if(idade>=0)
            {
                idades.Add(idade);
            }
            else{break;}
        }
        if(idades.Count>0)
        {Console.WriteLine($"{idades.Average():F2}");}
        else{Console.WriteLine(0);}
    }
}


//pode ser necessário ajustar a cultura para printar corretamente em sua máquina