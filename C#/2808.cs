using System; 


class URI {

    static void Main(string[] args) 
    { 
      string[] lista = Console.ReadLine().Split();

      string a = lista[0];
      string b = lista[1];

      //a

      int ax = a[0] -'a'+1;
      int ay = a[1]-'0';
      int bx = b[0] -'a'+1;
      int by = b[1]-'0';

    if(Math.Abs(ax-bx)>2 || Math.Abs(ay-by)>2)
    {
        Console.WriteLine("INVALIDO");
    }
    else if((Math.Abs(ax-bx)==2 && Math.Abs(ay-by)==1) ||(Math.Abs(ax-bx)==1 && Math.Abs(ay-by)==2))
    {
        Console.WriteLine("VALIDO");
    }
    else{Console.WriteLine("INVALIDO");

    }





       
        
    }

}