using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Security.Principal;
using SmallFunctions;
using System.Text.Json;

namespace LazyTask;

public class GetINFO
{
    public string Name {get; set;} = String.Empty;
    public string version {get; set;}
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Guid Id { get; set; } =  Guid.NewGuid();
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
            //Console.Clear();
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