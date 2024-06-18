using System;


class URI {
    static void Main(string[] args) 
    {   
        int n = int.Parse(Console.ReadLine());
        string[] lista = Console.ReadLine().Split();
        for(int i = 0; i < n-1;i++)
        {
            if(lista[i].Length==3 && lista[i][0] =='O' && lista[i][1]=='B')
            {
                Console.Write("OBI"+" ");
            }

            else if(lista[i].Length==3 && lista[i][0] =='U' && lista[i][1]=='R')
            {
                Console.Write("URI"+" ");
            }
            else{
                Console.Write(lista[i]+" ");
            }
        }
         if(lista[lista.Length-1].Length==3 && lista[lista.Length-1][0] =='O' && lista[lista.Length-1][1]=='B')
            {
                Console.WriteLine("OBI");
            }

            else if(lista[lista.Length-1].Length==3 && lista[lista.Length-1][0] =='U' && lista[lista.Length-1][1]=='R')
            {
                Console.WriteLine("URI");
            }
            else{
                Console.WriteLine(lista[lista.Length-1]);
            }


    }
}
