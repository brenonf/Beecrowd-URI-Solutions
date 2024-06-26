using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
         char[] c = new char[]
        {
            'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 
            'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z',
            'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 
            'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z'
        };
        char[] nome;
        int cont=0;

        int n = int.Parse(Console.ReadLine());
        for(int i =0;i<n;i++)
        {
            nome = Console.ReadLine().ToCharArray();
            foreach(char letra in nome)
            {
                if(c.Contains(letra))
                {
                    cont++;
                    if(cont==3)
                    {break;}
                }
                else{cont=0;}
            }
            if(cont==3)
            {Console.WriteLine($"{string.Join("",nome)} nao eh facil");}
            else{Console.WriteLine($"{string.Join("",nome)} eh facil");}
            cont=0;
        }
    }
}