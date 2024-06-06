using System;


class URI {

    static void Main(string[] args) 
    { 
      int n = int.Parse(Console.ReadLine());
      int hob=0;
      int hum=0;
      int elf=0;
      int ana=0;
      int mag=0;


      for(int i =0;i<n;i++)
      {
        string[] nome =Console.ReadLine().Split();

        switch(nome[1])
        {
            case "X":
            hob+=1;
            break;

            case "M":
            mag+=1;
            break;

            case "H":
            hum+=1;
            break;

            case "E":
            elf+=1;
            break;

            case "A":
            ana+=1;
            break;
        }

      }

      Console.WriteLine($"{hob} Hobbit(s)");
      Console.WriteLine($"{hum} Humano(s)");
      Console.WriteLine($"{elf} Elfo(s)");
      Console.WriteLine($"{ana} Anao(oes)");
      Console.WriteLine($"{mag} Mago(s)");
       
    }
}
