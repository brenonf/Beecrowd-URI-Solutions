using System;
using System.Linq;

class Program {
    static void Main() 
    {
        int[][] tudo = new int[9][];
        int[][] transposto = new int[9][];
        int[] validador = new int[9];
        bool repetido = false;
        
        int instancia =1;

        int n = int.Parse(Console.ReadLine());
        for(int j =0;j<n;j++)
        {
        int lin=0;
        int col=0;
        int aux=0;
        repetido =false;
        for(int l = 0; l < 9; l++)
        {
            tudo[l] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(tudo[l].Distinct().Count() != 9)
            {
                repetido = true;
                break;
            }
        }

        

        if (!repetido)
        {
            //transpor a matriz >>> se repetido == true nem precisa fazer essa parte
            for (int c = 0; c < 9; c++)
            {
                transposto[c] = new int[9];
                for (int l = 0; l < 9; l++)
                {
                    transposto[c][l] = tudo[l][c];
                }
            }
            //validando colunas se há repetidos.....
            for (int l = 0; l < 9; l++)
            {
                if (/*tudo[l].Distinct().Count() != 9 || */transposto[l].Distinct().Count() != 9)
                {
                    repetido = true;
                    break;
                }
            }

            
            while(!repetido)
            {
                for(int l=lin; l<lin+3;l++)
                {
                    for(int c=col;c<col+3;c++)
                    {
                        validador[aux]=tudo[l][c];
                        aux++;
                    }
                }
                if(validador.Distinct().Count() != 9)
                {
                    repetido=true;
                    break;
                }
                aux=0;
                col+=3;
                if(col==9)
                {
                    col=0;
                    lin+=3;
                    if(lin==9)
                    {break;}
                }
            }
            

        }

        if(!repetido)
        {
        Console.WriteLine($"Instancia {instancia}\nSIM");
        }
        else
        {
        Console.WriteLine($"Instancia {instancia}\nNAO");
    
        }
        instancia++;
        Console.WriteLine();
    }
    }
}
