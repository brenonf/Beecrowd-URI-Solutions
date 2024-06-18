using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string a = "", b = "";
            int tamanho = 0;
            string aux;

            a = Console.ReadLine();
            b = Console.ReadLine();

            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                break; 
            }

            if (a.Length > b.Length)
            {
                aux = a;
                a = b;
                b = aux;
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j <= a.Length; j++) 
                {
                    if (b.Contains(a.Substring(i, j - i))) 
                    {
                        if (tamanho < a.Substring(i, j - i).Length)
                        {
                            tamanho = a.Substring(i, j - i).Length;
                            //aqui ta o bo ver depois
                        }
                    }
                }
            }
            Console.WriteLine(tamanho);
        }
    }
}
