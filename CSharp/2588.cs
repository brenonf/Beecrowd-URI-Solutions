using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        string x;
        Dictionary<char,int> dicionarao = new Dictionary<char,int>();

        while(true)
        {
            x=Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}

            foreach(char c in x)
            {
                if(dicionarao.ContainsKey(c))
                {dicionarao[c]++;}
                else{dicionarao[c]=1;}
            }
            int cont=0;
            foreach(int a in dicionarao.Values)
            {
                if(a%2!=0)
                {cont++;}
            }

            Console.WriteLine(cont<=1?0 : cont-1);
            dicionarao.Clear();


        }
    }
}
