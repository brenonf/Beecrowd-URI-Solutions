using System; 

class URI {

    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int num;

        for(int i=0;i<n;i++)
        {
            num = int.Parse(Console.ReadLine());
            if(num>0 && num%2==0)
            {Console.WriteLine("EVEN POSITIVE");}
            else if(num>0 && num%2!=0)
            {Console.WriteLine("ODD POSITIVE");}
            else if(num<0 && num%2==0)
            {Console.WriteLine("EVEN NEGATIVE");}
            else if(num<0 &&num%2!=0)
            {Console.WriteLine("ODD NEGATIVE");}
            else{Console.WriteLine("NULL");}
            
        }
    }

}