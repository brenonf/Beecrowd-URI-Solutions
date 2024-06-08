using System;

class Program
{
    static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null && line != "")
        {
            string[] n = line.Split();
            int l = int.Parse(n[0]);
            int c = int.Parse(n[1]);
            int xp = 0;
            int yp = 0;
            int xh = 0;
            int yh = 0;

            int[][] m = new int[l][];

            for (int i = 0; i < l; i++)
            {
                m[i] = new int[c];
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < c; j++)
                {
                    m[i][j] = int.Parse(input[j]);
                    if (m[i][j] == 1)
                    {
                        xh = j;
                        yh = i;
                    }
                    else if (m[i][j] == 2)
                    {
                        xp = j;
                        yp = i;
                    }
                }
            }
            Console.WriteLine(Math.Abs(xp - xh) + Math.Abs(yh - yp));
        }
    }
}
