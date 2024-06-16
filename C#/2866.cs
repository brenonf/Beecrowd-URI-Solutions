using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] s;
            string print="";

            for(int i=0; i<n; i++)
            {
                s = Console.ReadLine().ToCharArray();

                foreach(char c in s)
                {
                    if(char.IsLower(c))
                    {
                        print = c + print;
                    }
                }
                Console.WriteLine(print);
                print="";
            }
           
        }
    }
}
