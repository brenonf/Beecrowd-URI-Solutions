using System; 

class URI {

    static void Main(string[] args) 
    { 
        string a;
        string[] frase;
        string maior="";
        string print="";
        while(true)
        {
            a=Console.ReadLine();
            if(a=="0")
            {break;}

            frase=a.Split();

            foreach (string x in frase)
            {
                if(x.Length >= maior.Length)
                {maior=x;}
                print+=x.Length+"-";
            }
            print = print.TrimEnd('-');
            Console.WriteLine(print);
            print="";
            

        }
        Console.WriteLine("");
        Console.WriteLine($"The biggest word: {maior}");
       
    }

}