using System;
using System.Linq;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        int[] n;
        int figuras=0;
        char[] comandos;
        char sentido='x';
        int linha=0;
        int coluna=0;

        while (true)
        {
            n=Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(n[0]==0 && n[1]==0 && n[2]==0)
            {break;}

            char[][] arena=new char[n[0]][];

            for(int i=0;i<n[0];i++)
            {
                arena[i]=Console.ReadLine().ToCharArray();
                if(sentido=='x')
                {
                    if(arena[i].Contains('N'))
                    {
                        sentido='N';
                        linha=i;
                        coluna=Array.IndexOf(arena[i],'N');
                    }
                    else if(arena[i].Contains('S'))
                    {
                        sentido='S';
                        linha=i;
                        coluna=Array.IndexOf(arena[i],'S');
                    }
                    else if(arena[i].Contains('L'))
                    {
                        sentido='L';
                        linha=i;
                        coluna=Array.IndexOf(arena[i],'L');

                    }
                    else if(arena[i].Contains('O'))
                    {
                        sentido='O';
                         linha=i;
                         coluna=Array.IndexOf(arena[i],'O');
                         }
                }

            }

            comandos =Console.ReadLine().ToCharArray();

            for(int i=0;i<n[2];i++)
            {
                if(comandos[i]=='D')
                {
                    switch(sentido)
                    {
                        case 'N':
                        sentido='L';
                        break;
                        case 'S':
                        sentido='O';
                        break;
                        case 'L':
                        sentido='S';
                        break;
                        case 'O':
                        sentido='N';
                        break;
                    }
                }
                else if(comandos[i]=='E')
                {
                    switch(sentido)
                    {
                        case 'N':
                        sentido='O';
                        break;
                        case 'S':
                        sentido='L';
                        break;
                        case 'L':
                        sentido='N';
                        break;
                        case 'O':
                        sentido='S';
                        break;
                    }
                }
                else
                {
                    switch(sentido)
                    {
                        case 'N':
                        if(linha-1>=0 && arena[linha-1][coluna]!='#')
                        {
                            linha-=1;
                            if(arena[linha][coluna]=='*')
                            {figuras++;arena[linha][coluna]='.';}
                        }
                        break;

                        case 'S':
                        if(linha+1<=n[0]-1 && arena[linha+1][coluna]!='#')
                        {
                            linha+=1;
                            if(arena[linha][coluna]=='*')
                            {figuras++;arena[linha][coluna]='.';}
                        }
                        break;

                        case 'L':
                        if(coluna+1<=n[1]-1 && arena[linha][coluna+1]!='#')
                        {
                            coluna+=1;
                            if(arena[linha][coluna]=='*')
                            {figuras++;arena[linha][coluna]='.';}
                        }
                        break;

                        case 'O':
                        if(coluna-1>=0 && arena[linha][coluna-1]!='#')
                        {
                            coluna-=1;
                            if(arena[linha][coluna]=='*')
                            {figuras++;arena[linha][coluna]='.';}
                        }
                        break;
                    }
                }
            }
            Console.WriteLine(figuras);
            figuras=0;
            sentido='x';




        }
    }
}