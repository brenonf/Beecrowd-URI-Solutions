using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string a="";
        string b="";
        int x;
        for(int i=0;i<n;i++)
        {
            a = Console.ReadLine();
            x = int.Parse(Console.ReadLine());
            foreach(char c in a)
            {
                if((int)c-x<65)
                {
                    b+=(char)((int)c-x+26);
                }
                else
                {
                b+=(char)((int)c-x);
                }

            }
            Console.WriteLine(b);
            b="";

        }
    }
}
