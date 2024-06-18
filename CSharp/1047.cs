using System;

class Program {
    static void Main(string[] args) {
        string[] x = Console.ReadLine().Split();
        int hi = int.Parse(x[0]);
        int mi = int.Parse(x[1]);
        int hf = int.Parse(x[2]);
        int mf = int.Parse(x[3]);

        int h, m;

        if (hi < hf) {
            h = hf - hi;
            if (mi < mf) {
                m = mf - mi;
            } else if (mi > mf) {
                h = h - 1;
                m = (60 - mi) + mf;
            } else {
                m = 0;
            }
        } else if (hi > hf) {
            h = (24 - hi) + hf;
            if (mi < mf) {
                m = mf - mi;
            } else if (mi > mf) {
                h = h - 1;
                m = (60 - mi) + mf;
            } else {
                m = 0;
            }
        } else {
            if (mi < mf) {
                m = mf - mi;
                h = 0;
            } else if (mi > mf) {
                m = (60 - mi) + mf;
                h = 23;
            } else {
                h = 24;
                m = 0;
            }
        }

        Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
    }
}
