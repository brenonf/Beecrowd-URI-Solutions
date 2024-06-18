using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {  
        while(true)
        {
            string x = Console.ReadLine();

            if(x==null)
            {break;}
            int n = int.Parse(x);

            if(n== 360 ||(n<90 && n>=0))
            {
                Console.WriteLine("Bom Dia!!");               
            }

            else if(n>=90 && n<180)
            {
                Console.WriteLine("Boa Tarde!!");
            }

            else if(n>=180 && n<270)
            {
                Console.WriteLine("Boa Noite!!");
            }

            else{
                Console.WriteLine("De Madrugada!!");
            }
        }        
    }
}