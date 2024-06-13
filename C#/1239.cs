using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {   
        string a;
        Regex regex1 = new Regex("_");
        Regex regex2 = new Regex(@"\*");
        while (true)
        {
            a = Console.ReadLine();
            if(string.IsNullOrEmpty(a))
            {break;}
            
            while(a.IndexOf("_") != -1)
            {
                
                a = regex1.Replace(a, "<i>", 1);
                a = regex1.Replace(a, "</i>", 1);             
            }
            while(a.IndexOf("*") != -1)
            {
                
                a = regex2.Replace(a, "<b>", 1);
                a = regex2.Replace(a, "</b>", 1);             
            }
            Console.WriteLine(a);
        }
    }
}
