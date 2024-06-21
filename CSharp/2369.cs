using System; 
class URI {

    static void Main(string[] args) 
    { 
        int tudo = int.Parse(Console.ReadLine());
        int n =tudo-10;
        int conta=7;

        if(tudo>10)
        {
            if(n-20>=0)
            {
                conta+=20;
                n-=20;
            }
            else{conta +=n; }
        }
        
        if(tudo>30)
        {
            if(n-70>=0)
            {
                conta+=70*2;
                n-=70;
            }
            else{conta +=n*2; }
        }

        if(tudo>100)
        {
            conta+=5*n;
        }

        Console.WriteLine(conta);
        
    }
}