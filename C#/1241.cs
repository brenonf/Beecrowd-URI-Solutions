using System;


class Program
{
    static void Main(string[] args)
    {
        int  n = int.Parse(Console.ReadLine());
        string a;
        string b;
        string c;
        for(int i =0;i<n;i++)
        {
            string[] x =Console.ReadLine().Split();
            a = x[0];
            b =x[1];

            if(a.Length >=b.Length)
            {
                c=a.Substring(a.Length-b.Length);

                if(b==c)
                {Console.WriteLine("encaixa");}
                else{Console.WriteLine("nao encaixa");}

            }
            else
            {Console.WriteLine("nao encaixa");}



        }

    }
}