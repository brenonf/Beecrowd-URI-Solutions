using System;


class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());  
        string voto ="S";
        int ponto = int.Parse(Console.ReadLine());  

        for(int i =0;i<n-1;i++)
        {
            int inimigo = int.Parse(Console.ReadLine());
            if(inimigo>ponto && voto=="S")
            {
                voto= "N";
            }
        }
        Console.WriteLine(voto);
       
       
    }
}
