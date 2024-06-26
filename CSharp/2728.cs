using System; 
using System.Linq;

class URI {

    static void Main(string[] args) 
    {
        string n;
        string p = "cobol";
        int cont=0;
        string[] frase;

        while(true) 
        {
            n = Console.ReadLine();
            if(string.IsNullOrEmpty(n))
            {break;}


            frase=n.ToLower().Split('-');

            for(int i=0;i<5;i++)
            {
                if (frase[i].StartsWith(p[i].ToString()) || frase[i].EndsWith(p[i].ToString()))
                {cont++;}
                else{break;}
            }

            if(cont==p.Length)
            {Console.WriteLine("GRACE HOPPER");}
            else{Console.WriteLine("BUG");}
            cont=0;

        }
    }
}