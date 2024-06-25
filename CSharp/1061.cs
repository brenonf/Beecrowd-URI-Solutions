using System;

class URI
{
    static void Main()
    {
        string wi = Console.ReadLine();
        string xi = Console.ReadLine();
        string wf = Console.ReadLine();
        string xf = Console.ReadLine();

        string[] wiParts = wi.Split();
        string[] wfParts = wf.Split();
        string[] xiParts = xi.Split();
        string[] xfParts = xf.Split();

        int di = int.Parse(wiParts[1]);
        int df = int.Parse(wfParts[1]);

        int hi = int.Parse(xiParts[0]);
        int mi = int.Parse(xiParts[2]);
        int si = int.Parse(xiParts[4]);

        int hf = int.Parse(xfParts[0]);
        int mf = int.Parse(xfParts[2]);
        int sf = int.Parse(xfParts[4]);

        int s = 0;
        int m = 0;
        int h = 0;
        int d = df - di;

        if (sf >= si)
        {
            s = sf - si;
        }
        else
        {
            s = 60 - si + sf;
            mf -= 1;
        }

        if (mf >= mi)
        {
            m = mf - mi;
        }
        else
        {
            m = 60 - mi + mf;
            hf -= 1;
        }

        if (hf >= hi)
        {
            h = hf - hi;
        }
        else
        {
            h = 24 - hi + hf;
            d -= 1;
        }

        if (d < 0)
        {
            d = 0;
        }

        Console.WriteLine($"{d} dia(s)");
        Console.WriteLine($"{h} hora(s)");
        Console.WriteLine($"{m} minuto(s)");
        Console.WriteLine($"{s} segundo(s)");
    }
}
