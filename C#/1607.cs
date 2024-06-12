using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cont = 0;
        int aux=0;
        
        
        for (int i = 0; i < n; i++)
        {
            string[] a = Console.ReadLine().Split();
            char[] a1 = a[0].ToCharArray();
            char[] a2 = a[1].ToCharArray();
            
            for (int j = 0; j < a1.Length; j++)
            {
                while (a1[j] != a2[j])
                {
                    if (a1[j] == 'z')
                    {
                        a1[j] = 'a';
                        aux++;
                    }
                    else
                    {
                        a1[j] = (char)(a1[j] + 1);
                        aux++;
                    }
                }
                cont += aux;
                aux = 0;
            }
            Console.WriteLine(cont);
            cont = 0;
        }
    }
}
