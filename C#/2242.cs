using System;

class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string b = "";
        string breverse="";

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
            {
                b += a[i];
                breverse=a[i]+breverse;
            }
        }
        if(b==breverse)
        {
          Console.WriteLine("S");
      }
      else
      {
        Console.WriteLine("N");
      }
}
}
