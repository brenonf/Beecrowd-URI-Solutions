using System; 
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


class URI {

    static void Main(string[] args) 
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        List<decimal> listao = new List<decimal>();
        decimal entrada;

        while(listao.Count<2)
        {
            entrada = decimal.Parse(Console.ReadLine());
            if(entrada>=0 && entrada<=10)
            {
                listao.Add(entrada);
            }
            else{Console.WriteLine("nota invalida");}

        }
        Console.WriteLine($"media = {listao.Average():F2}");

    }

}

