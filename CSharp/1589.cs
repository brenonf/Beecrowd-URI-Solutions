using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int x = int.Parse(Console.ReadLine());
        int[] y;
        for(int i =0;i<x;i++)
        {
            y = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(y.Sum());
        }
    }

}