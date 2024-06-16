using System;


class Program
{
    static void Main(string[] args)
    {   
        string a;
        int n = 0;
        string nova;
        string velha;
        char[] texto;
        char[] lista1;
        char[] lista2;

        while(true)
        {
            a=Console.ReadLine();
            if(string.IsNullOrEmpty(a))
            {break;}

            n = int.Parse(a.Split()[1]);
            nova =Console.ReadLine();
            velha = Console.ReadLine();
            lista1 =(nova+velha).ToLower().ToCharArray();
            lista2 =(velha+nova).ToLower().ToCharArray();

            for(int i = 0;i<n;i++)
            {
                texto = Console.ReadLine().ToCharArray();

                for(int j = 0;j<texto.Length;j++)
                {

                    if(char.IsUpper(texto[j]))
                    {
                        if(Array.IndexOf(lista1,char.ToLower(texto[j]))!=-1)
                        {
                            texto[j] = char.ToUpper(lista2[Array.IndexOf(lista1,char.ToLower(texto[j]))]);
                        } 
                    }
                    else
                    {
                        if(Array.IndexOf(lista1,texto[j])!=-1)
                        {
                            texto[j] = lista2[Array.IndexOf(lista1,texto[j])];
                                            

                        } 
                    }
                    
                    }
                    Console.WriteLine(texto);
                    
                }
                Console.WriteLine();

            }


        }
    }


