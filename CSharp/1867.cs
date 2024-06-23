using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        string[] n;
        char[] algarismo;
        int a;
        int b;
        int soma=0;

        while (true) 
        {
            n = Console.ReadLine().Split();
            if(n[0]=="0" && n[1]=="0")
            {break;}

            


            for(int i=0;i<2;i++)
            {
                while(n[i].Length!=1)
                {
                    algarismo=n[i].ToCharArray();
                    foreach(char c in algarismo)
                    {
                        soma+= int.Parse(c.ToString());
                    }
                    n[i]=soma.ToString();
                    soma=0;
                }
                soma=0;
            }
            a=int.Parse(n[0]);
            b=int.Parse(n[1]);

            if(a>b)
            {Console.WriteLine(1);}
            else if(a<b)
            {Console.WriteLine(2);}
            else{Console.WriteLine(0);}


        }
    }
}