using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        int[] x = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a=x[0];
        int b=x[1];
        int c=x[2];
        int d=x[3];

        if(b>c &&d>a &&c+d>a+b &&c>=0 &&d>=0 &&a%2==0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else{Console.WriteLine("Valores nao aceitos");}

    }

}