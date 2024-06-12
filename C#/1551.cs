using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());
        string a;
        int cont=0;
        int[] lista = new int[26];

        for(int i = 0; i < n;i++)
        {
            a = Console.ReadLine();
            foreach(char c in a)
            {
                if(char.IsLower(c))
                {
                    lista[(int)(c)-97]+=1;
                }
            }
            cont =lista.Count(x => x == 0);
            if(cont == 0)
            {Console.WriteLine("frase completa");}
            else if(cont<=13)
            {Console.WriteLine("frase quase completa");}
            else{Console.WriteLine("frase mal elaborada");}
            
            for(int j=0; j<26;j++)
            {
                lista[j]=0;
            }
            cont=0;

        }
        
    }

}