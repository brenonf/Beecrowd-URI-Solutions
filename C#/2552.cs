
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n=0;
        int m=0;
        int cont=0;
        
        string[] entrada;
        string teste;
        
        while(true)
        {   
            teste =Console.ReadLine();
            if (teste==null)
                {break;}
            entrada = teste.Split();
            
            n= int.Parse(entrada[0]);
            m = int.Parse(entrada[1]);
            string[,] lista = new string[n,m];
            
            for(int i = 0; i < n ; i++)
            {
                entrada = Console.ReadLine().Split(); 
                for(int j = 0 ; j<m; j++)
                {
                    if(entrada[j]=="1")
                    {
                        lista[i,j]="9";
                    }
                    else
                    {lista[i,j] = entrada[j];}
                    
                }
            }
            
            
            for(int i = 0; i < n ; i++)
            {
                 
                for(int j = 0 ; j<m; j++)
                {
                    if(lista[i,j]=="0")
                    {
                        //cima
                        if (i-1>=0)
                        {
                            if (lista[i-1,j]=="9")
                            {cont+=1;}
                        }
                        
                        //baixo
                        if (i+1<=(n-1))
                        {
                            if (lista[i+1,j]=="9")
                            {cont+=1;}
                        }
                        
                        //direita
                        if (j+1<=(m-1))
                        {
                            if (lista[i,j+1]=="9")
                            {cont+=1;}
                        }
                        
                        //esquerda
                        if (j-1>=0)
                        {
                            if (lista[i,j-1]=="9")
                            {cont+=1;}
                        }
                        lista[i,j]=Convert.ToString(cont);
                        cont=0;
                    }
                    
                }
            }
            
            
            for(int i = 0; i < n ; i++)
            {
                for(int j = 0 ; j<m; j++)
                {
                    Console.Write(lista[i,j]);
                }
                Console.WriteLine("");
            }
            
            
            
            
            
            
            
            
            
            
        }
    }
}