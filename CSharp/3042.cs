using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {      //string flag="kkkk";
        while(true)
        {
           int n = int.Parse(Console.ReadLine());
           if(n==0)
           {break;}
           string[,] pista = new string[n,3];
           for(int i=0; i<n;i++)
           {
                string[] novaLinha = Console.ReadLine().Split();

                for(int j =0; j<3; j++)
                {
                    pista[i,j] = novaLinha[j];
                }
           }     
            int cont =0;
            string lado ="c";// e =0 // c=1 // d=2

            for(int i =0; i<n;i++)
            {
                if(lado =="c")
                {
                    if(pista[i,1]!="0") //se centro não der para passar, então..
                    {
                        if(pista[i,0]=="0")
                        {
                            cont+=1;
                            lado="e";
                        }

                        if(pista[i,2]=="0")
                        {
                            cont+=1;
                            lado="d";
                        }
                    }
                    
                }

                else if(lado =="e")
                {
                    if(pista[i,0]!="0") //se esquerda não der para passar, então..
                    {
                        if(pista[i,1]=="0")
                        {
                            cont+=1;
                            lado="c";
                        }

                        if(pista[i,2]=="0")
                        {
                            cont+=2;
                            lado="d";
                        }
                    }
                }

                else
                {
                    if(pista[i,2]!="0") //se direita não der para passar, então..
                    {
                        if(pista[i,1]=="0")
                        {
                            cont+=1;
                            lado="c";
                        }

                        if(pista[i,0]=="0")
                        {
                            cont+=2;
                            lado="e";
                        }
                    }
                }

            }
            Console.WriteLine(cont);

        }
    }
}