using System;
using System.Collections.Generic;
using System.Linq;


class URI {
    static void Main(string[] args) 
    {
        HashSet<char> vogal = new HashSet<char>();
        string texto;
        string teste;
        int cont=0;

        while(true)
        {
            teste = Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}

            vogal = teste.ToHashSet();
            texto = Console.ReadLine();

            foreach(char c in texto)
            {
                if(vogal.Contains(c))
                {cont++;}
            }
            Console.WriteLine(cont);
            cont=0;
        }
    }
}