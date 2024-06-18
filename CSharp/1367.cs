using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    {
        while(true)
        {
        int n = int.Parse(Console.ReadLine());
        Dictionary<char,int> soma = new Dictionary<char,int>();

        if(n==0)
        {break;}
        int s=0;
        int p=0;
        int pAcumulo=0;
        string[] a;
        int[] print = new int[n];

        for(int i = 0; i < n;i++)
        {
            a = Console.ReadLine().Split();

            if(!soma.ContainsKey(char.Parse(a[0]))) 
            {
                soma[char.Parse(a[0])] = 0;
            }

            if(a[2]=="correct")
            {
                p+= int.Parse(a[1]) + soma[char.Parse(a[0])];
                s++;
            }
            else
            {
                soma[char.Parse(a[0])]+=20;
            }
        }
        Console.WriteLine($"{s} {p}");

    }
    }

}