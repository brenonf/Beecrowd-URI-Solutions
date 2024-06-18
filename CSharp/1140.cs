using System;

class URI {

    static void Main(string[] args) 
    { 
        string[] lista;
        int cont=0;


        while (true) 
        {
            lista = Console.ReadLine().Split();
            if (lista.Length == 1 && lista[0]=="*")
            {
                break;
            }
            foreach (string s in lista)
            {
                if(lista[0][0].ToString().ToLower()==s[0].ToString().ToLower())
                {cont++;}
                else{break;}
            }
            if(cont==lista.Length)
            {Console.WriteLine("Y");}
            else{Console.WriteLine("N");}
            cont=0;

        }
    }
} 