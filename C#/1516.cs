using System; 
using System.Linq;
class URI {

    static void Main(string[] args) 
    { 
        int n;
        int m;
        int a;
        int b;
        int[] aux;
        string print="";

        while(true)
        {
        aux = Console.ReadLine().Split().Select(int.Parse).ToArray();
        n = aux[0];
        m=aux[1];
        if(n == 0 && m==0)
        {break;}
        char[][] desenho = new char[n][];
        for(int i=0; i<n; i++)
        {
            desenho[i] = Console.ReadLine().ToCharArray();
        }

        aux = Console.ReadLine().Split().Select(int.Parse).ToArray();
        a = aux[0];
        b = aux[1];

        for(int i=0; i<n;i++)
        {
            for(int j=0; j<a/n;j++)
            {
                foreach(char x in desenho[i])
                {   
                    for(int k=0;k<b/m;k++){
                    print+=x;}
                }
                Console.WriteLine(print);
                print="";
            }
            }
            Console.WriteLine();

        }





    }

}