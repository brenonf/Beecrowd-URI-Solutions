using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        int[] listao = new int[100];
        for (int i = 0;i<100;i++)
        {
            listao[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(listao.Max());
        Console.WriteLine(1+Array.IndexOf(listao,listao.Max()));
    }

}