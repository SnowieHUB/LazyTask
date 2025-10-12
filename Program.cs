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
        Console.BackgroundColor = ConsoleColor.White;
        bool loop = true;
        
        while (loop)
        {
            MainMenu.Banner();
            MainMenu.PrintMenu();
            MainMenu.Menu();
        }
    }
}