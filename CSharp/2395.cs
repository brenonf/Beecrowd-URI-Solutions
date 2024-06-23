using System;
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int print=0;
        int[] conteiner = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] navio =  Console.ReadLine().Split().Select(int.Parse).ToArray();

        if(conteiner[0]>navio[0] || conteiner[1]>navio[1] || conteiner[2]>navio[2])
        {print=0;}
        else
        {
            print = (navio[0]/conteiner[0])*(navio[1]/conteiner[1])*(navio[2]/conteiner[2]);
        }
        Console.WriteLine(print);
        

    }

}