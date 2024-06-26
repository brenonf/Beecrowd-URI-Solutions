using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> dois = Console.ReadLine().Split().Select(int.Parse).ToList();
        int x;
        for(int i=0;i<n[0];i++)
        {
            x = int.Parse(Console.ReadLine());
            if(dois.Contains(x))
            {
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(1);
                dois.Add(x);
                }
        }

    }
}