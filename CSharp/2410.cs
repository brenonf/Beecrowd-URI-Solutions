using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    {
        HashSet<int> listao = new HashSet<int>();
        int n = int.Parse(Console.ReadLine());

        for(int i =0;i<n;i++)
        {
            listao.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(listao.Count);
    }
}