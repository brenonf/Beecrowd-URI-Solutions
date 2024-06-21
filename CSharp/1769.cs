using System; 

class URI {

    static void Main(string[] args) 
    {   
        string cpf;
        int a1=0;
        int a2=0;
        int a3=0;
        int a4=0;
        int a5=0;
        int a6=0;
        int a7=0;
        int a8=0;
        int a9=0;
        int b1=0;
        int b2=0;
        int d1=0;
        int d2=0;

        while(true)
        {
            cpf = Console.ReadLine();
            if(string.IsNullOrEmpty(cpf))
            {break;}

        a1 = int.Parse(cpf[0].ToString());
        a2 = int.Parse(cpf[1].ToString());
        a3 = int.Parse(cpf[2].ToString());
        a4 = int.Parse(cpf[4].ToString());
        a5 = int.Parse(cpf[5].ToString());
        a6 = int.Parse(cpf[6].ToString());
        a7 = int.Parse(cpf[8].ToString());
        a8 = int.Parse(cpf[9].ToString());
        a9 = int.Parse(cpf[10].ToString());
        d1 = int.Parse(cpf[12].ToString());
        d2 = int.Parse(cpf[13].ToString()); 
                   
            b1=(a1*1+a2*2+a3*3+a4*4+a5*5+a6*6+a7*7+a8*8+a9*9)%11;
            b2=(a1*9+a2*8+a3*7+a4*6+a5*5+a6*4+a7*3+a8*2+a9*1)%11;
            if(b1==10)
            {b1=0;}
            if(b2==10)
            {b2=0;}
            if(b1==d1 && b2==d2)
            {Console.WriteLine("CPF valido");}
            else{Console.WriteLine("CPF invalido");}



        }
        

    }

}