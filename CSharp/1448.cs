using System; 

class URI {

    static void Main(string[] args) 
    { 
        int time1=0;
        int time2=0;
        char[] instancia;
        char[] i1;
        char[] i2;
        int m;
        bool desempate1 = false;
        bool desempate2 = false;



        int n = int.Parse(Console.ReadLine());

        for(int i =0; i < n; i++)
        {
            instancia = Console.ReadLine().ToCharArray();
            i1 = Console.ReadLine().ToCharArray();
            i2 = Console.ReadLine().ToCharArray();

            m=instancia.Length;

            for(int j = 0; j < m;j++)
            {
                if(instancia[j] == i1[j])
                {
                    time1++;
                }
                if(instancia[j]==i2[j])
                {
                    time2++;
                }
                if (!desempate1 && !desempate2 && time1!=time2)
                {
                    if (instancia[j] == i1[j] && instancia[j] != i2[j])
                    {
                        desempate1 = true;
                    }
                    else if (instancia[j] == i2[j] && instancia[j] != i1[j])
                    {
                        desempate2 = true;
                    }
                }
            }


            Console.WriteLine($"Instancia {i+1}");

            if(time1 > time2)
            {Console.WriteLine("time 1");}
            else if(time2>time1){Console.WriteLine("time 2");}
            else if(desempate1)
            {
                Console.WriteLine("time 1");
            }
            else if(desempate2)
            {
                Console.WriteLine("time 2");
            }
            else{Console.WriteLine("empate");}
            time1=0;
            time2=0;
            desempate1=false;
            desempate2=false;
            Console.WriteLine();
        }
    }

}