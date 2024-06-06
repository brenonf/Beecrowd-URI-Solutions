using System; 

class URI {

    static void Main(string[] args) 
    { 
       int n = int.Parse(Console.ReadLine());
       int gasto = 0;
       int verba = 0;

       for(int i =0; i<n;i++)
       {
        string[] lista = Console.ReadLine().Split();
        
        if(lista[0]=="V")
        {
            verba+= int.Parse(lista[1]);
        }
        else{
            gasto+= int.Parse(lista[1]);
        }

       }

       if(verba>=gasto)
       {Console.WriteLine("A greve vai parar.");}
       else
       {Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!");}
        
    }

}