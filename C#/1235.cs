using System;


class Program
{
    static void Main(string[] args)
    {
        int  n = int.Parse(Console.ReadLine());
        string a;
        string b="";
        string c="";
        string result="";
        for(int i=0;i<n;i++)
        {
            a=Console.ReadLine();
            b+=a.Substring(0,a.Length/2);
            foreach(char ch in b)
            {
                c= ch + c;
            }
            result+=c;
            c="";
            b="";
            b+=a.Substring(a.Length/2,a.Length/2);
            foreach(char ch in b)
            {
                c= ch + c;
            }
            result+=c;

            Console.WriteLine(result);
            result="";
            c="";
            b="";
        }
    }
}