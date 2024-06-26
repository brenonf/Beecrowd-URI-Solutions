using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        string print = "S";
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[][] linha = new int[n[0]][];

        for (int i = 0; i < n[0]; i++)
        {
            linha[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int lin = 0; lin < n[0]; lin++)
        {
            int col = 0;

            while (col < n[1] && linha[lin][col] == 0)
            {
                col++;
            }

            if (col < n[1])
            {
                for (int prox = lin + 1; prox < n[0]; prox++)
                {
                    if (linha[prox][col] != 0)
                    {
                        print = "N";
                        break;
                    }
                    for (int i = 0; i < col; i++)
                    {
                        if (linha[prox][i] != 0)
                        {
                            print = "N";
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int prox = lin + 1; prox < n[0]; prox++)
                {
                    if (linha[prox].Any(x => x != 0))
                    {
                        print = "N";
                        break;
                    }
                }
            }

            if (print == "N")
            {
                break;
            }
        }
        Console.WriteLine(print);
    }
}
