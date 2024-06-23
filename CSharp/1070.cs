using System; 

class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        if(n%2==0)
        {n++;}
        
        for(int i = 0; i < 12; i+=2)
        {
            Console.WriteLine(i+n);
        }
    }

}