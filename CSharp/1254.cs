using System;
using System.Text.RegularExpressions;

class URI {
    static void Main(string[] args) 
    {
        string entrada;
        string sub;
        string frase;
        string padrao;
        string print;

        while(true)
        {
            entrada=Console.ReadLine();
            if(string.IsNullOrEmpty(entrada))
            {break;}

            sub=Console.ReadLine();
            frase=Console.ReadLine();

            padrao = $@"<[^>]*?({entrada})[^>]*?>";

            print=Regex.Replace(frase,padrao,m =>
            {
                string x = m.Value;
                string trocado = Regex.Replace(x, entrada, sub, RegexOptions.IgnoreCase);
                return trocado;
            }, RegexOptions.IgnoreCase);

            Console.WriteLine(print);
        }
    }
}
