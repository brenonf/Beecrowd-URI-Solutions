using System;

class URI {

    static void Main(string[] args) { 
        char[] s;
        string print="";
        while(true)
        {
            string x = Console.ReadLine();
            if(string.IsNullOrEmpty(x))
            {break;}
        s = x.ToCharArray();
        
        for(int j=s.Length-1;j>=0;j--)
        {
            for(int i = 0; i < j;i++)
            {
                print+=s[i] +" ";
            }
            print+=s[j];
            while(print.Length<s.Length*2-1)
            {
                print= " "+ print+" ";
            }
            print= print.TrimEnd();
            Console.WriteLine(print);
            
            print="";
        }
        Console.WriteLine();
        }
        

       

    }

}