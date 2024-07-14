using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        int n;

        while(true)
        {
            n =int.Parse(Console.ReadLine());
            if(n==0)
            {break;}

            if(n!=1){
            char[][] m =Matriz(n);

            Printada(m,n);}
            else{Console.WriteLine("X");Console.WriteLine("@");}



        }
    }

    static char[][] Matriz(int n)
    {
        char[][] x = new char[n][];
        for (int i = 0; i < n; i++)
        {
            x[i] = new char[n]; 
            for (int j = 0; j < n; j++)
            {
                x[i][j]='O'; 
            }
        }
        x[n/2][n/2] = 'X';

        return x;
    }

    static void Printada(char[][] m, int n)
    {
        int direita=1;
        int cima=1;
        int esquerda=2;
        int baixo=2;
        int direitaBaixo=2;

        int x=n/2;
        int y=n/2;
        
        while(true)
        {
            if(x==n/2 && y==n/2)
            {
                m[x][y]='X';
                for(int i =0;i<n;i++)
                {
                    Console.WriteLine(string.Join("",m[i]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }

            for(int i=1;i<=direita;i++)
            {
                y+=1;
                m[x][y]='X';
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine(string.Join("",m[j]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }

            for(int i=1;i<=cima;i++)
            {
                x-=1;
                m[x][y]='X';
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine(string.Join("",m[j]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }
            cima+=2;

            for(int i=1;i<=esquerda;i++)
            {
                y-=1;
                m[x][y]='X';
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine(string.Join("",m[j]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }
            esquerda+=2;

            for(int i=1;i<=baixo;i++)
            {
                x+=1;
                m[x][y]='X';
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine(string.Join("",m[j]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }
            baixo+=2;

            for(int i=1;i<=direitaBaixo;i++)
            {
                y+=1;
                m[x][y]='X';
                for(int j =0;j<n;j++)
                {
                    Console.WriteLine(string.Join("",m[j]));
                }
                Console.WriteLine("@");
                m[x][y]='O';
            }
            direitaBaixo+=2;

            if(x==n-1 && y==n-1)
            {break;}

        }

    }
}