using System;
using System.Linq;
using System.Text;

class URI
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string x;
        long y=0;
        StringBuilder print = new StringBuilder();

        for(int i = 0; i < n;i++)
        {
            string[] nada = Console.ReadLine().Split();
            x=nada[0];
            y=long.Parse(nada[1]);

            for(int j=0;j<x.Length;j++)
            {
                if(y%2==0 && x[j]=='X')
                {
                    print.Append("X");
                    y=y/2;
                }
                else if(y%2==0 && x[j]=='O')
                {
                    print.Append("O");
                    y=y/2;
                }
                else if(y%2!=0 && x[j]=='X')
                {
                    print.Append("O");
                    if(y==1){y=0;}
                    else{y=y/2;}
                    
                }
                else if(y%2!=0 && x[j]=='O')
                {
                    print.Append("X");
                    y=y/2+1;
                }
            }
            Console.WriteLine(print);
            print.Clear();
        }
    }
}
