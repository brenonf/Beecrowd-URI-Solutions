using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    return; 
                }

                string[] x = line.Split(' ');

                if (x.Length != 2)
                {
                    Console.WriteLine("Entrada inválida. Foram esperados dois números separados por espaço.");
                    return; 
                }

                int N = Convert.ToInt32(x[0]);
                int Q = Convert.ToInt32(x[1]);
                int q = 0;

                int[] lista = new int[N];

                for (int i = 0; i < N; i++)
                {
                    lista[i] = Convert.ToInt32(Console.ReadLine());
                }

                Array.Sort(lista);
                Array.Reverse(lista);

                for (int i = 0; i < Q; i++)
                {
                    q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lista[q - 1]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
