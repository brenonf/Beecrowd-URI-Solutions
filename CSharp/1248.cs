using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());
        char[] dieta;
        string cafe;
        string almoco;
        char[] tudo;
        string print="";
        string[] prints = new string[n];
        int menor=0;

        for(int i = 0; i < n;i++)
        {
            dieta = Console.ReadLine().ToCharArray();
            cafe = Console.ReadLine();
            almoco = Console.ReadLine();
            tudo =(cafe+almoco).ToCharArray();
            
            Array.Sort(dieta);
            Array.Sort(tudo);

            


            if(tudo.Length != tudo.Distinct().Count())
            {
                print="CHEATER";
            }
            else if(tudo.Except(dieta).Any())
            {
                print="CHEATER";;
            }
            else
            {
                for(int j=0; j<dieta.Length;j++)
                {
                    if(tudo.Contains(dieta[j])==false)
                    {print+=dieta[j];}
                }
            }
            prints[i]= print;
            print="";


        }
        foreach(string s in prints)
        {Console.WriteLine(s);}
        
    }

}