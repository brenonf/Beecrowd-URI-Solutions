using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class URI
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();// <abrev,palavra>
        StringBuilder print = new StringBuilder();
        string[] x= new string[] { ""};
        int y=0;
        int cont=0;
        string antiga;
        string nova;
        

        while(true)
        {
           antiga = Console.ReadLine();
           if(antiga==".")
           {break;}
           x=antiga.Split();
            y=x.Length;
            int controle = antiga.Length;

           for(int i = 0;i<y;i++)
           {
                if(!dic.ContainsKey($"{x[i][0]}.") && x[i].Length>2)
                {
                    dic[$"{x[i][0]}."]=x[i];
                }
                else if
                (
                    x[i].Length>2 && 
                    antiga.Replace(x[i]+" ",$"{x[i][0]}. ").Replace(" "+x[i],$" {x[i][0]}.").Length<
                    antiga.Replace(dic[$"{x[i][0]}."]+" ",$"{x[i][0]}. ").Replace(" "+dic[$"{x[i][0]}."],$" {x[i][0]}.").Length
                )
                {
                    dic[$"{x[i][0]}."]=x[i];
                }
            }
                /*
                if(!dic.ContainsKey($"{x[i][0]}.") && x[i].Length>2)
                {
                    dic[$"{x[i][0]}."]=x[i];
                }
                else if(x[i].Length>2 && dic[$"{x[i][0]}."].Length<x[i].Length)
                {
                    dic[$"{x[i][0]}."]=x[i];
                }*/
        

           for(int i=0;i<y;i++)
           {
                if(dic.ContainsValue(x[i]))
                {
                    print.Append(dic.FirstOrDefault(a => a.Value == x[i]).Key+" ");
                    cont++;
                }
                else{
                    print.Append(x[i]+" ");
                }
           }
           print.Remove(print.Length - 1, 1);
           Console.WriteLine(print);
           print.Clear();
           Console.WriteLine(dic.Count);
           var dicOrdenado = dic.OrderBy(item => item.Key);
           foreach (var item in dicOrdenado)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            cont=0;
            dic.Clear();
        }
    }
}




/*
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class URI
{
    static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();// <abrev,palavra>
        StringBuilder print = new StringBuilder();
        string[] x;
        int y;
        int cont=0;
        

        while(true)
        {
           x = Console.ReadLine().Split();
           if(x[0]=="." &&x.Length==1)
           {break;}
            y=x.Length;

           for(int i = 0;i<y;i++)
           {
                if(!dic.ContainsKey($"{x[i][0]}.") && x[i].Length>2)
                {
                    dic[$"{x[i][0]}."]=x[i];
                }
                else if(x[i].Length>2 && dic[$"{x[i][0]}."].Length<x[i].Length)
                {
                    dic[$"{x[i][0]}."]=x[i];
                }
           }

           for(int i=0;i<y;i++)
           {
                if(dic.ContainsValue(x[i]))
                {
                    print.Append(dic.FirstOrDefault(a => a.Value == x[i]).Key+" ");
                    cont++;
                }
                else{
                    print.Append(x[i]+" ");
                }
           }
           print.Remove(print.Length - 1, 1);
           Console.WriteLine(print);
           print.Clear();
           Console.WriteLine(dic.Count);
           var dicOrdenado = dic.OrderBy(item => item.Key);
           foreach (var item in dicOrdenado)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            cont=0;
            dic.Clear();
        }
    }

}
*/