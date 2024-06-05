using System; 

class URI {

    static void Main(string[] args) 
    { 
        while(true)
        {
        string nn = Console.ReadLine();
        if(nn==null)
        {break;}

        int n = int.Parse(nn);
        for(int i =0;i<n;i++)
        {
        string lista = Console.ReadLine();
        if(lista==null)
        {break;}
        int cont = 1;
        string comparacao = ".";
        char letra;

        while(true)
        {   
            if(lista != comparacao)
            {
                letra = Convert.ToChar(96+cont);
                
                // Console.WriteLine(letra);
                // Console.WriteLine(cont);
                // Console.WriteLine(comparacao);
                // Console.WriteLine("");

                switch(cont%3)
                {
                    
                    case 1:
                    {
                        comparacao = comparacao.Replace(".","..");
                        
                        break;
                    }

                    case 2:
                    {
                        comparacao = comparacao.Replace("..","...");
                        
                        break;
                    }

                    case 0:
                    {
                        comparacao = comparacao.Replace("...",".");
                        comparacao = comparacao+" .";
                        
                        break;
                    }
                }
                
                
                
                cont+=1;
                


            }
            else
            {
                letra = Convert.ToChar(96+cont);
                
                Console.WriteLine(letra);
                //Console.WriteLine(cont);
                //Console.WriteLine(comparacao);
                //Console.WriteLine("");
                break;
            }
        }
        }



        }
    }

}