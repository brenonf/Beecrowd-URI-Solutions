using System;
using System.Linq;
using System.Collections.Generic;


class URI {

    static void Main(string[] args) 
    { 
      int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int n = lista[0];
    int g = lista[1];
    string[] lista2;
    int soma=0;

    Dictionary<string, int> runas = new Dictionary<string, int>();

    for(int i =0;i<n;i++)
    {
        lista2 = Console.ReadLine().Split();
        runas.Add(lista2[0],int.Parse(lista2[1]));
    }

    int x = int.Parse(Console.ReadLine());
    string[] lista3 = Console.ReadLine().Split();

    foreach(string i in lista3)
    {
        soma+= runas[i];
    }

    Console.WriteLine(soma);
    if(soma>=g)
    {
       Console.WriteLine("You shall pass!"); 
    }
    else{
               Console.WriteLine("My precioooous"); 

    }

       
    }
}
