using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Security.Principal;
using SmallFunctions;

namespace LazyTask;

public class GetINFO
{
    public string name {get; set;}
    public string version {get; set;}
}

public class ItemsTask
{
    public string TaskName {get; set;}
}
class Program
{
    public static List<string> taskitems = new();
    static void Main(string[] args)
    {
        Console.Title = "LazyTask";
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.ResetColor();
            MainMenu.Banner();
            MainMenu.PrintMenu();
            MainMenu.Menu();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char key = keyInfo.KeyChar;
            string s = key.ToString();
            if (s == "y" || s == "q")
            {

                Console.WriteLine($"\nALT + F4");
                Console.WriteLine($"Go to sleep.");
                Smallfunc.Delay3S();
                loop = false;
            }
            else if (s == "n")
            {
                loop = true;
            }
        }
    }
}