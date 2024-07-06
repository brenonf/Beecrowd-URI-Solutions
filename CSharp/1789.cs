using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        List<char> print = new List<char>();
        int x;
        int[] listao;
        string teste;

        while(true)
        {
            teste=Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}

            x = int.Parse(teste);
            listao = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(listao);

            if(listao[x-1]<10)
            {print.Add('1');}

            else if(listao[x-1]>=10 && listao[x-1]<20)
            {print.Add('2');}

            else{print.Add('3');}

        }
        foreach(char c in print)
        {Console.WriteLine(c);}
    }
}