using System; 

class URI {

    static void Main(string[] args) 
    { 
        int x= int.Parse(Console.ReadLine());
        int y= int.Parse(Console.ReadLine());
        int z= int.Parse(Console.ReadLine());

        string a = x.ToString();
        string b = y.ToString();
        string c = z.ToString();

        
        string A;
        string B;
        string C;

        Console.WriteLine($"A = {a}, B = {b}, C = {c}");

        A= "                  "+ a;
        B= "                  "+ b;
        C= "                  "+ c;
        
        Console.WriteLine($"A = {A.Substring(A.Length-10)}, B = {B.Substring(B.Length-10)}, C = {C.Substring(C.Length-10)}");

        A= "000000000000000000"+ a;
        B= "000000000000000000"+ b;
        C= "000000000000000000"+ c;
        
        if(a[0]=='-')
        {
            A = a.Substring(1,a.Length-1);
             A= "000000000000000000"+ A;
             A=A.Substring(A.Length-9);
            A= "-"+A;
            Console.WriteLine($"A = {A}, B = {B.Substring(B.Length-10)}, C = {C.Substring(C.Length-10)}");
        }
        else{
        Console.WriteLine($"A = {A.Substring(A.Length-10)}, B = {B.Substring(B.Length-10)}, C = {C.Substring(C.Length-10)}");
        }


        A= a+"                  ";
        B= b+"                  ";
        C= c+"                  ";
        
        Console.WriteLine($"A = {A.Substring(0,10)}, B = {B.Substring(0,10)}, C = {C.Substring(0,10)}");

    }

}