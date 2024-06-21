using System; 
using System.Collections.Generic;

class URI {

    static void Main(string[] args) 
    { 
        //se alguem em algum momento estiver lendo isso, tente verificar que todos angulos multiplos de 6 darão "Y". Não é preciso toda essa volta que eu fiz.
        List<int> angulos = new List<int>();

        int hora=0;
        int minuto=0;
        int cont=0;

        while(cont<=720)
        {
            for(int i =0; i<12; i++)
            {
                angulos.Add
                (
                    Math.Min(Math.Abs(hora-minuto),Math.Abs(minuto-hora))*6
                    
                );
                minuto++;
                
            }
            hora+=5;
            cont+=5;
            if(minuto==60)
            {minuto=0;}
            if(hora==60)
            {hora=0;}
        }
        string n;
        while(true)
        {
            n=Console.ReadLine();
            if(string.IsNullOrEmpty(n))
            {break;}

            if(angulos.Contains(int.Parse(n)))
            {
                Console.WriteLine("Y");
            }
            else{Console.WriteLine("N");}
        }


      
    }

}