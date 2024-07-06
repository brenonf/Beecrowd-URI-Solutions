using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        char x= char.Parse(Console.ReadLine());
        char[] y = Console.ReadLine().ToCharArray();

        Console.WriteLine(y.Count(a=>a==x));
    }

}