using System;
using System.Linq;

class URI
{
    static void Main()
    {
        long numDecimal;
        string numBinario;
        long resto=0;
        string[] lista;
        long maior=0;

        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            numDecimal = long.Parse(Console.ReadLine());
            numBinario = "";
            
            if (numDecimal == 0)
            {
                numBinario = "0";
            }
            else
            {
                while (numDecimal > 0)
                {
                    resto = numDecimal % 2;
                    numBinario = resto + numBinario;
                    numDecimal /= 2;
                }
            }
            lista=numBinario.Split('0').ToArray();
            foreach(string sequencia in lista)
            {
                if(sequencia.Length>maior)
                {maior=sequencia.Length;}
            }
            Console.WriteLine(maior);
            maior=0;
        }
    }
}
