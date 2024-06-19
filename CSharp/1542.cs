using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
      int[] n;
      int q;
      int d;
      int p;
      decimal paginas;
      string x;
      CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

      while(true)
      {
        x = Console.ReadLine();
        if(x=="0")
        {break;}
        n = x.Split().Select(int.Parse).ToArray();
        
        q=n[0];
        d=n[1];
        p=n[2];
        paginas = Math.Floor((decimal)(p*q*d)/(p-q));
        if(paginas >1)
        {
        Console.WriteLine($"{paginas} paginas");
        }
        else{
            Console.WriteLine($"{paginas} pagina");

        }
      }
    }
}
/*Então você resolveu contar as páginas dos 
livros, aumentando também a quantidade de 
páginas lidas por dia. Agora você lê 5 páginas 
por dia e termina 16 dias antes do que se estivesse 
lendo 3 páginas por dia. Neste cenário, quantas páginas 
tem o livro?

p*x=paginas
q*(x+d)= paginas

x = paginas/5

paginas = 3*(pag/5+16)*/
