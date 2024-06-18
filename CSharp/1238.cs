using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for(int i =0;i<n;i++)
        {

            string[] x = Console.ReadLine().Split();
            string a = x[0];
            string b = x[1];

            string c="";

            if(a.Length<b.Length)
            {
                for(int j=0;j<a.Length;j++)
                {
                    c+= a[j];
                    c+=b[j];
                }
                c+=b.Substring(a.Length,b.Length-a.Length);
                Console.WriteLine(c);
            }

             else if(a.Length>b.Length)
            {
                for(int j=0;j<b.Length;j++)
                {
                    c+= a[j];
                    c+=b[j];
                }
                c+=a.Substring(b.Length,a.Length-b.Length);
                Console.WriteLine(c);
            }
            else
            {
                for(int j=0;j<b.Length;j++)
                {
                    c+= a[j];
                    c+=b[j];
                }
                c+=a.Substring(b.Length,a.Length-b.Length);
                Console.WriteLine(c);
            }
            c="";
            }
            

        }
    }

     