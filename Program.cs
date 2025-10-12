using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Security.Principal;

namespace LazyTask;

public class GetINFO
{
    public string name {get; set;}
    public string version {get; set;}
}
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "LazyTask";
        bool loop = true;
        while (loop)
        {
            MainMenu.Banner();
            MainMenu.PrintMenu();
            MainMenu.Menu();
            
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            string s = key.ToString();
            if (s == "y")
            {
                Console.WriteLine($"ALT + F4");
                Console.WriteLine($"Go to sleep.");
                loop = false;
            }
            else if (s == "n")
            {
                loop = true;
            }
        }
    }
}