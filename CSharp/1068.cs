using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string expression = Console.ReadLine();
            int sum = 0;

            if (string.IsNullOrEmpty(expression))
            {
                break;
            }

            foreach (char ch in expression)
            {
                if (ch == '(')
                {
                    sum++;
                }
                else if (ch == ')')
                {
                    sum--;
                    if (sum < 0)
                    {
                        Console.WriteLine("incorrect");
                        break; 
                    }
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("correct");
            }
            else if (sum > 0)
            {
                Console.WriteLine("incorrect"); 
            }
        }
    }
}
