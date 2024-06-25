using System;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {
        float[] listao =new float[12];
        int l = int.Parse(Console.ReadLine());
        char c =char.Parse(Console.ReadLine());

        for(int i = 0; i < 12;i++)
        {
            for(int j=0; j < 12;j++)
            {
                if(j==l)
                {
                    listao[i]=float.Parse(Console.ReadLine());
                }
                else{Console.ReadLine();}
            }
        }
        if(c=='S')
        {
            Console.WriteLine($"{listao.Sum():F1}");
        }
        else{Console.WriteLine($"{listao.Average():F1}");
}
    }
}
