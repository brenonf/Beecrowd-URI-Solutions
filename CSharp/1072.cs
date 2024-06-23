using System; 

class URI {

    static void Main(string[] args) 
    {
        int contIn =0;
        int contOut =0;
        int num;
        int n = int.Parse(Console.ReadLine());
        
        for(int i=0;i<n;i++)
        {
            num = int.Parse(Console.ReadLine());
            if(num>20 || num<10)
            {contOut++;}
            else{contIn++;}
        }
        Console.WriteLine($"{contIn} in");
        Console.WriteLine($"{contOut} out");
    }

}