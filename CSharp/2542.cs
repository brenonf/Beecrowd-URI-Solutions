using System;
using System.Linq;

class URI 
{

    static void Main(string[] args) 
    { 
        while(true)
        {
            

        string nn = Console.ReadLine();  

        if(nn==null)
        {break;} 

        int n =int.Parse(nn);

        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int m = x[0];
        int l = x[1];
        int[,] ma =new int[m,n];
        int[,] le = new int[l,n];

        for(int i=0;i<m;i++)
        {
            string[] lista = Console.ReadLine().Split();

            for(int j = 0;j<n;j++)
            {
                ma[i,j]=int.Parse(lista[j]);
            }
        }


        for(int i=0;i<l;i++)
        {
            string[] lista2 = Console.ReadLine().Split();

            for(int j = 0;j<n;j++)
            {
                le[i,j]=int.Parse(lista2[j]);
            }
        }

        string[] cartas = Console.ReadLine().Split();

        int atributo = int.Parse(Console.ReadLine());

        if(ma[int.Parse(cartas[0])-1,atributo-1]>le[int.Parse(cartas[1])-1,atributo-1])
        {Console.WriteLine("Marcos");}

        else if(ma[int.Parse(cartas[0])-1,atributo-1]<le[int.Parse(cartas[1])-1,atributo-1])
        {Console.WriteLine("Leonardo");}

        else{Console.WriteLine("Empate");}

    }
    }

        
}







