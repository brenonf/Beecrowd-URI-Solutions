using System; 


class URI {

    static void Main(string[] args) 
    { 
      string a = Console.ReadLine();
      string b = Console.ReadLine();

      if(string.Compare(a,b)<0)
      {
        Console.WriteLine(a);
         Console.WriteLine(b);
      }
      else{
        Console.WriteLine(b);
         Console.WriteLine(a);
      }

     
        
    }

}