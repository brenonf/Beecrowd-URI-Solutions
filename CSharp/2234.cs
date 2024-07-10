using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int[] x =Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine($"{(decimal)x[0]/x[1]:F2}");

    }

}