using System;
using System.Linq;

class URI
{
    static void Main()
    {
        while(true)
        {
            string x = Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
            Console.WriteLine(x.Replace(" .",".").Replace(" ,",","));

        }
    }
}
