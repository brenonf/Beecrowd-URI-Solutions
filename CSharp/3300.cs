using System;

class URI {

    static void Main(string[] args) 
    {
        string a = Console.ReadLine();

        if (a.Contains("13"))
        {
            Console.WriteLine($"{a} es de Mala Suerte");
        }
        else
        {
            Console.WriteLine($"{a} NO es de Mala Suerte");
        }
    }
}
