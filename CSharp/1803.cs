using System; 
using System.Linq;
using System.Text;

class URI 
{

    static void Main(string[] args) 
    {
        int[][] matriz = new int[4][];
        

        for (int i = 0; i<4;i++)
        {
            matriz[i] = Console.ReadLine().Select(c => int.Parse(c.ToString())).ToArray();
        }
        int n = matriz[0].Length;
        StringBuilder aux = new StringBuilder();

        int[] numeros = new int[n];

        for(int col =0;col<n;col++)
        {
            for(int lin =0;lin<4;lin++)
            {
                aux.Append(matriz[lin][col]);
            }
            numeros[col]=int.Parse(aux.ToString());
            aux.Clear();
        }
        for(int i = 1;i<n-1;i++)
        {
            aux.Append((char)((numeros[0]*numeros[i]+numeros[n-1])%257));
        }
        Console.WriteLine(aux);



    }
}