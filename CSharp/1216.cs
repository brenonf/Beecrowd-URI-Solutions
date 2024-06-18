using System;
//using System.Linq;
using System.Globalization;


class Program {
    static void Main() 
    {
        double media=0;
        int cont=0;
        string nome;
        
       while(true) 
       {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        nome = Console.ReadLine();
        if(string.IsNullOrEmpty(nome))
        {break;}
        media += int.Parse(Console.ReadLine());
        cont++;
       }
       Console.WriteLine($"{media/cont:F1}");
    }
}
       
   