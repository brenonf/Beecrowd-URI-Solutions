using System;
using System.Text;
using System.Linq;

class URI
{
    static void Main()
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = a[0];
        int y = a[1];

        int aux = 1;

        while (aux <= y)
        {
            StringBuilder print = new StringBuilder();
            for (int i = 0; i < x && aux <= y; i++)
            {
                if (i > 0)
                {
                    print.Append(" ");
                }
                print.Append(aux);
                aux++;
            }
            Console.WriteLine(print.ToString());
        }
    }
}
