using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] a;
        int aux = 0;
        int cont = 0;
        StringBuilder print = new StringBuilder();

        for(int i = 0; i < n;i++)
        {
            a = Console.ReadLine().Split();
            foreach(string s in a)
            {if(s.Length > aux)
            {
                aux=s.Length;
            }}

            while(cont!=a.Length)
            {
                foreach(string s in a)
                {
                    if(s.Length == aux)
                    {
                        print.Append(s +" ");
                        cont++;
                    }

                }
                aux--;
            }
            Console.WriteLine(print.ToString().TrimEnd());
            print.Clear();
            cont=0;
            

        }
    }
}