using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            string a = Console.ReadLine();
            if(a == null || a == "")
            {
                break;
            }
            bool flagUpper = true;
            string b = "";
            foreach(char i in a)
            {
                if(i != ' ' && flagUpper == true)
                {
                    b += char.ToUpper(i);
                    flagUpper = false;
                }
                else if(i == ' ')
                {
                    b += i;                    
                }
                else if(i != ' ' && flagUpper == false)
                {
                    b += char.ToLower(i);
                    flagUpper = true;
                }
            }
            Console.WriteLine(b);
        }
    }
}
