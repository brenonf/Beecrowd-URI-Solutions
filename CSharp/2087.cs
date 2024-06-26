using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        while(true) 
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 0) break;

            string[] listao = new string[n];
            for(int i = 0; i < n; i++)
            {
                listao[i] = Console.ReadLine();
            }

            Array.Sort(listao, (a, b) => a.Length.CompareTo(b.Length));

            bool bom = true;

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(listao[j].StartsWith(listao[i]))
                    {
                        bom = false;
                        break;
                    }
                }
                if(!bom) break;
            }

            if(bom)
            {
                Console.WriteLine("Conjunto Bom");
            }
            else
            {
                Console.WriteLine("Conjunto Ruim");
            }
        }
    }
}
