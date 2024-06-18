using System;

class Program
{
    static void Main(string[] args)
    {
        string a;
        int n;
        int l; // linhas por pg
        int c; // numero max de carac/linha
        string[] texto;

        while ((a = Console.ReadLine()) != null)
        {
            if(string.IsNullOrEmpty(a))
            {
                break;
            }
            n = int.Parse(a.Split()[0]);
            l = int.Parse(a.Split()[1]);
            c = int.Parse(a.Split()[2]);

            texto = Console.ReadLine().Split();

            int paginas = 1;
            int linhas = 1;
            int caracteres = 0;

            foreach (string tex in texto)
            {
                if (caracteres + tex.Length <= c)
                {
                    caracteres += tex.Length + 1;
                }
                else
                {
                    linhas++;    //bo aqui
                    if (linhas > l)  
                    {
                        paginas++;
                        linhas = 1;
                    }
                    caracteres = tex.Length + 1;
                }
            }
            Console.WriteLine(paginas);
        }
    }
}
