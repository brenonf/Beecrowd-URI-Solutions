using System;


class Program {
    static void Main() 
    {
        int cont=0;
        decimal x;

        for(int i=0;i<6;i++)
        {
            x = decimal.Parse(Console.ReadLine());
            if(x>0) cont++;
        }
        Console.WriteLine($"{cont} valores positivos");
    }
}
       
   