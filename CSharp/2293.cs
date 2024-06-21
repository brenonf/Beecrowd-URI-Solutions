using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        
        int maior=0;

        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[][] normal = new int[n[0]][];
        int[][] transposta = new int[n[1]][];

        for (int i=0; i<n[0]; i++)
        {
            normal[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int i=0; i<n[1];i++)
        {
            transposta[i] = new int[n[0]]; 

            for (int j = 0; j < n[0]; j++)
            {
                transposta[i][j] = normal[j][i]; 
            }
        }

        for(int i = 0; i<n[0];i++)
        {
            if(normal[i].Sum()>maior)
            {maior=normal[i].Sum();}
        }
        for(int i=0; i<n[1];i++)
        {
            if(transposta[i].Sum()>maior)
            {maior=transposta[i].Sum();}
        }
        Console.WriteLine(maior);



        
    }
}
