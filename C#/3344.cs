using System;
using System.Collections.Generic;



class URI 
{

    static void Main(string[] args) 
    { 
        int  itera;
        int x = int.Parse(Console.ReadLine());
        for(int i =0; i<1000;i++)
        {
            itera = letras(x);
            x=itera;

        }
        Console.WriteLine(x);
    }








    static int letras(int x)
    {
        int dezena;
        int unidade;
        Dictionary<int, int> listao = new Dictionary<int, int>()
        {
            {1, 3}, {2, 3}, {3, 5}, {4, 4}, {5, 4},
            {6, 3}, {7, 5}, {8, 5}, {9, 4}, {10, 3},
            {11, 6}, {12, 6}, {13, 8}, {14, 8}, {15, 7},
            {16, 7}, {17, 9}, {18, 8}, {19, 8}, {20, 6},
            {30, 6}, {40, 5}, {50, 5}, {60, 5}, {70, 7},
            {80, 6}, {90, 6}, {100, 7}
        };

        if(listao.ContainsKey(x))
        {
            return listao[x];
        }
        else{
            dezena = 10*(x/10);
            //unidade=x%100;
            unidade=x%10;
            return listao[dezena]+ listao[unidade];

        }
    }
     
    }

