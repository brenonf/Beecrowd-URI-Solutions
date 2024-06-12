using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string a;
        string b="";

        for(int i =0;i<n;i++)
        {
            a = Console.ReadLine();
            foreach(char c in a) // +3
            {
                if(char.IsUpper(c) || char.IsLower(c))
                {
                    b+=(char)((int)c+3);
                }
                else
                {
                    b+=c;
                }
                
            }
            
            a="";
            foreach(char c in b) //reverter
            {
                a=c+a;
            }
            
            b="";
            b=a.Substring(0,a.Length/2);

            for(int j=a.Length/2;j<a.Length;j++)//-1
            {   
                b+= (char)((int)a[j]-1);
            }
            Console.WriteLine(b);
            b="";


        }
    }
}