using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                break;
            }
            else
            {
                int sobra = 0;

                for (int i = 1; i <= n; i++)
                {
                    int[] lista = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    

                    if (lista[1] % 2 == 0)
                    {
                        sobra += lista[1];
                    }
                    else
                    {
                        sobra += lista[1] - 1;
                    }
                }

                Console.WriteLine(sobra / 4);
            }
        }
    }
}
