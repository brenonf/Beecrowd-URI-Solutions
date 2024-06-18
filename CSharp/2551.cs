using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                break;
            }
            short n = short.Parse(input);

            float[] medias = new float[n + 1];

            for (short i = 1; i <= n; ++i)
            {
                string[] values = Console.ReadLine().Split();
                float x = float.Parse(values[0]);
                float y = float.Parse(values[1]);
                medias[i] = y / x;
            }

            Console.WriteLine("1");
            float maior = medias[1];
            for (short i = 2; i <= n; ++i)
            {
                if (medias[i] > maior)
                {
                    maior = medias[i];
                    Console.WriteLine(i);
                }
            }
        }
    }
}
