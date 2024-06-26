using System;
using System.Text;

class URI {
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder final = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string nome = Console.ReadLine();
            string sobre = Console.ReadLine();
            int max = Math.Max(nome.Length, sobre.Length);

            for (int j = 0; j < max; j += 2)
            {
                if (j < nome.Length)
                {
                    int nomeLen = Math.Min(2, nome.Length - j);
                    final.Append(nome.Substring(j, nomeLen));
                }

                if (j < sobre.Length)
                {
                    int sobreLen = Math.Min(2, sobre.Length - j);
                    final.Append(sobre.Substring(j, sobreLen));
                }
            }

            Console.WriteLine(final.ToString());
            final.Clear();
        }
    }
}
