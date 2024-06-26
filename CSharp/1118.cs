using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main()
    {
        List<float> nota = new List<float>();
        float x;
        bool True =true;

        while(True)
        {
            while(True)
            {
                x = float.Parse(Console.ReadLine());
                if(x<0 || x>10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    nota.Add(x);
                }

                if(nota.Count==2)
                {
                    Console.WriteLine($"media = {nota.Average():F2}");
                    nota.Clear();
                    break;
                }
            }
            while(True)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = float.Parse(Console.ReadLine());
                if(x==2)
                {True=false;break;}
                else if(x==1)
                {break;}
            }
        }
    }
}