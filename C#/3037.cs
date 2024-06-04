using System;



public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0;i<n;i++)
        {
            int maria = 0;
            int joao=0;

            for(int j =0;j<3;j++)
            {
                string[] jogada = Console.ReadLine().Split();
                joao+= int.Parse(jogada[0]) * int.Parse(jogada[1]);
            }

            for(int j =0;j<3;j++)
            {
                string[] jogada = Console.ReadLine().Split();
                maria+= int.Parse(jogada[0]) * int.Parse(jogada[1]);
            }

            if(joao>maria)
            {Console.WriteLine("JOAO");}
            else
            {Console.WriteLine("MARIA");}


        }
    }   

}
