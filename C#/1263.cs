using System;


class URI {
    static void Main(string[] args) 
    {   
        string[] a;
        string x;
        int cont =0;
        int aux =0;
        while (true)
        {   
             x = Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
            x=x.ToLower();
            a= x.Split();
            
            for(int i=0; i<a.Length-1; i++)
            {
                if(a[i][0]==a[i+1][0] && aux==0)
                {
                    aux++;
                }
                else if(a[i][0]!=a[i+1][0])
                {   
                    if(aux>=1)
                    {
                        cont++;
                    }
                    aux=0;
                }

            }
            if(aux>=1)
            {
                cont++;
            }
            Console.WriteLine(cont);
            cont=0;
            aux=0;
        }
    }

}

