using System; 
using System.Linq;
using System.Collections.Generic;


class URI {

    static void Main(string[] args) 
    {   
        string teste;
        List<int> inicio;
        List<int> fim;
        int n;
        int cont=0;
        int indice1=0;
        int indice2=0;
        int aux;

        while(true)
        {
            teste = Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}
            n=int.Parse(teste);
            inicio = Console.ReadLine().Split().Select(int.Parse).ToList();
            fim = Console.ReadLine().Split().Select(int.Parse).ToList();

            while(!inicio.SequenceEqual(fim))
            {
                indice1 = inicio.IndexOf(fim[indice2]);
                cont+=Math.Abs(indice2-indice1);
                aux =inicio[indice1];
                inicio.RemoveAt(indice1);
                inicio.Insert(indice2,aux);

                if(indice2==n-1)
                {indice2=0;}
                else{indice2++;}
            }

            Console.WriteLine(cont);
            cont=0;
            indice2=0;
            
        }
    }
}