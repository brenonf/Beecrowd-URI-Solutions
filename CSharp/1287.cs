using System;
using System.Text;

class URI {
    static void Main(string[] args) { 
        string x;
        while((x = Console.ReadLine()) != null) {
            StringBuilder sb = new StringBuilder();
            bool error = false;
            foreach (char c in x) {
                if (c >= '0' && c <= '9') sb.Append(c);
                else if (c == 'o' || c == 'O') sb.Append('0');
                else if (c == 'l') sb.Append('1');
                else if (c != ' ' && c != ',') { error = true; break; }
            }
            if (!error) {
                long outro;
                if (long.TryParse(sb.ToString(), out outro) && outro <= 2147483647) {
                    Console.WriteLine(outro);
                    continue;
                }
            }
            Console.WriteLine("error");
        }
    }
}
