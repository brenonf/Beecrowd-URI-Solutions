using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    {
        SortedDictionary<int,string> listao = new SortedDictionary<int,string>();
        string[] entrada;
        

        while(true)
        {
            string a = Console.ReadLine();
            if(string.IsNullOrEmpty(a))
            {break;}
            int x = int.Parse(a);
            string print="";

            for(int i =0;i<x;i++)
            {
                entrada = Console.ReadLine().Split();
                listao[int.Parse(entrada[1])]=entrada[0];
            }

            foreach(var item in listao)
            {
                print +=item.Value+" ";
            }
            print =print.TrimEnd();
            Console.WriteLine(print);
            listao.Clear();
        }
    }

}