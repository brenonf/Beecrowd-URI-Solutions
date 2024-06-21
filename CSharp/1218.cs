using System; 
using System.Linq;


class URI {

    static void Main(string[] args) 
    {   
        string[] lista;
        string a;
        int f=0;
        int m=0;
        int pares=0;
        int caso =1;
        

        while (true) 
        {
            a = Console.ReadLine();
            if(string.IsNullOrEmpty(a))
            {break;}
            if(caso>1)
            {Console.WriteLine();
}
            lista = Console.ReadLine().Split();

            for(int i=0;i<lista.Length;i+=2)
            {
                if(lista[i]==a)
                {
                    pares++;
                    if(lista[i+1]=="M")
                    {m++;}
                    else{f++;}
                }
            }
            Console.WriteLine($"Caso {caso}:");
            Console.WriteLine($"Pares Iguais: {pares}");
            Console.WriteLine($"F: {f}");
            Console.WriteLine($"M: {m}");
            m=0;
            f=0;
            pares=0;
            caso++;
        }
    }
}