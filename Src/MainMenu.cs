namespace LazyTask;

public class MainMenu
{
    public static void Banner()
    {
        /*
         *+--------------------------------------------------------------------+
          |                                                                    |
          | ██╗      █████╗ ███████╗██╗   ██╗████████╗ █████╗ ███████╗██╗  ██╗ |
          | ██║     ██╔══██╗╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝ |
          | ██║     ███████║  ███╔╝  ╚████╔╝    ██║   ███████║███████╗█████╔╝  |
          | ██║     ██╔══██║ ███╔╝    ╚██╔╝     ██║   ██╔══██║╚════██║██╔═██╗  |
          | ███████╗██║  ██║███████╗   ██║      ██║   ██║  ██║███████║██║  ██╗ |
          | ╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ |
          |                                                                    |
          +--------------------------------------------------------------------+
         */
        
        
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@"+--------------------------------------------------------------------+");
        Console.WriteLine(@"|                                                                    |");
        Console.WriteLine(@"| ██╗      █████╗ ███████╗██╗   ██╗████████╗ █████╗ ███████╗██╗  ██╗ |");
        Console.WriteLine(@"| ██║     ██╔══██╗╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝ |");
        Console.WriteLine(@"| ██║     ███████║  ███╔╝  ╚████╔╝    ██║   ███████║███████╗█████╔╝  |");
        Console.WriteLine(@"| ██║     ██╔══██║ ███╔╝    ╚██╔╝     ██║   ██╔══██║╚════██║██╔═██╗  |");
        Console.WriteLine(@"| ███████╗██║  ██║███████╗   ██║      ██║   ██║  ██║███████║██║  ██╗ |");
        Console.WriteLine(@"| ╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ |");
        Console.WriteLine(@"|                                             Made by @RP            |");
        Console.WriteLine(@"+--------------------------------------------------------------------+");
        Console.ResetColor();
    }

    public static void Menu()
    {
        ConsoleKeyInfo userInput = Console.ReadKey();
        char key = userInput.KeyChar;
        string s = key.ToString();
        
        switch (s)
        {
            case "n":
                AddnewTask();
                break;
            case "r":
                RemoveTask();
                break;
            case "q":
                Exit();
                break;
        }
    }

    public static void AddnewTask()
    {
        Console.WriteLine($"Test");
    }

    public static void RemoveTask()
    {
        
    }
    public static void Exit()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("ALT + F4");
        Console.WriteLine("Go to sleep.");
        Console.ResetColor();
    }
    public static void PrintMenu()
    {
        
        Console.WriteLine($"Add new task");
    }
}