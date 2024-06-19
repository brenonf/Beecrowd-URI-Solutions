using System;
using System.Linq;
using System.Text;


class Program 
{
    static void Main() 
    {
        int[] lista1;
        int[] lista2;
        StringBuilder print = new StringBuilder();
        string teste;


        while(true)
        {   
            teste = Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}
            lista1 = teste.Split().Select(int.Parse).ToArray();
            lista2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int i=1;i<=lista1[0];i++)
            {
                if(!lista2.Contains(i))
                {
                    print.Append(i+" ");
                }
            }

            if(print.Length>0)
            {
            Console.WriteLine(print.ToString());
            }
            else{Console.WriteLine("*");}
            print.Clear();


        }
    }
}