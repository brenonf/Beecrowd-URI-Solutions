using System;

class URI {
    static void Main(string[] args) 
    {   
        int n = int.Parse(Console.ReadLine());
        int soma=0;
        string a;
        string aux="";

        for(int i = 0; i < n;i++)
        {
            a=Console.ReadLine();

            foreach(char c in a)
            {
                if(Char.IsDigit(c))
                {
                    aux+=c;
                }
                else if(Char.IsDigit(c)==false && aux.Length>0 )
                {
                    soma+=int.Parse(aux);
                    aux="";
                }
            }
            if(aux.Length>0)
            {
                soma+=int.Parse(aux);
                aux="";
            }
            Console.WriteLine(soma);
            soma=0;
        }
    }
}