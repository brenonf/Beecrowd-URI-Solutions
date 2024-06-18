using System;
using System.Text;

class URI {
    static void Main(string[] args) 
    {   
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            int[] lista = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            StringBuilder a = new StringBuilder();

            for(int j = lista[0]; j <= lista[1]; j++)
            {
                a.Append(j);
            }

            for(int k = a.Length - 1; k >= 0; k--)
            {
                a.Append(a[k]);
            }

            Console.WriteLine(a.ToString());
        }
    }
}
