using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int soma=1;
        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach(int a in x)
        {
            soma+= a-1;
        }
        Console.WriteLine(soma);
    }

}