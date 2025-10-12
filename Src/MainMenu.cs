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
        
        Console.SetWindowPosition((Console.WindowWidth / 2) - (Console.WindowWidth / 2),Console.CursorTop);
        Console.Clear();
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
                Console.WriteLine("\nDo you want to quit? [Y/N]");
                break;
        }
    }

    public static void AddnewTask()
    {
        Console.Clear();
        Console.WriteLine($"=== Add new Task ===");
    }
    public static void RemoveTask()
    {
        
    }
    public static void PrintMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Add new task"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"                                     n\n"); Console.ResetColor();
        Console.Write($"Remove a Task"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"                                    r\n"); Console.ResetColor();
        Console.Write($"Quit"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"                                             q\n"); Console.ResetColor();
        Console.WriteLine();
    }
}