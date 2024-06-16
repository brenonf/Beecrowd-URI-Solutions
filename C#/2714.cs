using System; 

class URI {

    static void Main(string[] args) 
    { 
        int n = int.Parse(Console.ReadLine());
        string[] print = new string[n];
        string a;

        for(int i=0; i<n; i++)
        {   
            a=Console.ReadLine();
            if(a.Length==20 && a[0]=='R' && a[1]=='A')
            {
                for(int j=2; j<a.Length;j++)
                {
                    if(a[j]!='0')
                    {
                        print[i]=a.Substring(j,a.Length-j);
                        break;
                    }
                }
            }
            else{print[i]="INVALID DATA";}
        }
        for(int i=0; i<print.Length;i++)
        {Console.WriteLine(print[i]);
        }
        
        
    }

}