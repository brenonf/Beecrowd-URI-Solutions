using System; 

class URI {

    static void Main(string[] args) 
    { 
        string teste;
        int n;
        string input;
        int EHD=0;
        int EPR=0;
        int intruso=0;
        
        while(true)
        {
            teste=Console.ReadLine();
            if(string.IsNullOrEmpty(teste))
            {break;}

            n= int.Parse(teste);    

            for(int i =0;i<n;i++)
            {
                input =Console.ReadLine().Split()[1];
                if(input=="EHD")
                {EHD++;}
                else if(input=="EPR")
                {EPR++;}
                else{intruso++;}
            }
            Console.WriteLine($"EPR: {EPR}");
            Console.WriteLine($"EHD: {EHD}");
            Console.WriteLine($"INTRUSOS: {intruso}");
            EPR=0;
            EHD=0;
            intruso=0;
        }

    }

}