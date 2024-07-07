using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                break;
            }

            List<List<int>> m = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                m.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    m[i].Add(0);
                }
            }

            m[0][0] = 1;
            for (int i = 0; i < n; i++)
            {
                if (i >= 1)
                {
                    m[i][0] = m[i - 1][0] * 2;
                }

                for (int j = 1; j < n; j++)
                {
                    m[i][j] = m[i][j - 1] * 2;
                }
            }

            int T = m[n - 1][n - 1].ToString().Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string s = m[i][j].ToString().PadLeft(T);
                    m[i][j] = int.Parse(s.Trim());
                }

                string M = string.Join(" ", m[i].ConvertAll(x => x.ToString().PadLeft(T)));
                Console.WriteLine(M);
            }
            Console.WriteLine();
        }
    }
}
