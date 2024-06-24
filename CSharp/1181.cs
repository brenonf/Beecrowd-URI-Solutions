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
            if(i==l)
            {
                for(int j = 0;j<12;j++)
                {
                    listao[j]=float.Parse(Console.ReadLine());
                }
            }
            else
            {
                for(int j = 0;j<12;j++)
                {
                    Console.ReadLine();
                }
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

//pode ser preciso ajustar a cultura para rodar certo em sua máquina