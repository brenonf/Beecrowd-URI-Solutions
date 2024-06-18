using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {   
        string[] nome = new string[4];
        nome[0]="Os atributos dos monstros vao ser inteligencia, sabedoria...";
        nome[1]="Iron Maiden's gonna get you, no matter how far!";
        nome[2]="Urano perdeu algo muito precioso...";
        nome[3]="Putz vei, o Leo ta demorando muito pra jogar...";

    while(true)
    {
      string a = Console.ReadLine();
      if(a==null)
      {
        break;
      }
      Dictionary<string, string> listao = new Dictionary<string, string>()
        {
            {"pedra pedra pedra", "4"},
            {"pedra pedra papel", "3"},
            {"pedra pedra tesoura", "4"},
            {"pedra papel pedra", "2"},
            {"pedra papel papel", "4"},
            {"pedra papel tesoura", "4"},
            {"pedra tesoura pedra", "4"},
            {"pedra tesoura papel", "4"},
            {"pedra tesoura tesoura", "1"},
            {"papel pedra pedra", "1"},
            {"papel pedra papel", "4"},
            {"papel pedra tesoura", "4"},
            {"papel papel pedra", "4"},
            {"papel papel papel", "4"},
            {"papel papel tesoura", "3"},
            {"papel tesoura pedra", "4"},
            {"papel tesoura papel", "2"},
            {"papel tesoura tesoura", "4"},
            {"tesoura pedra pedra", "4"},
            {"tesoura pedra papel", "4"},
            {"tesoura pedra tesoura", "2"},
            {"tesoura papel pedra", "4"},
            {"tesoura papel papel", "1"},
            {"tesoura papel tesoura", "4"},
            {"tesoura tesoura pedra", "3"},
            {"tesoura tesoura papel", "4"},
            {"tesoura tesoura tesoura", "4"}
        };

        
      Console.WriteLine(nome[int.Parse(listao[a])-1]);

    }
                
    }
}

