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
        string banner = @"


          +--------------------------------------------------------------------+
          |                                                                    |
          | ██╗      █████╗ ███████╗██╗   ██╗████████╗ █████╗ ███████╗██╗  ██╗ |
          | ██║     ██╔══██╗╚══███╔╝╚██╗ ██╔╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝ |
          | ██║     ███████║  ███╔╝  ╚████╔╝    ██║   ███████║███████╗█████╔╝  |
          | ██║     ██╔══██║ ███╔╝    ╚██╔╝     ██║   ██╔══██║╚════██║██╔═██╗  |
          | ███████╗██║  ██║███████╗   ██║      ██║   ██║  ██║███████║██║  ██╗ |
          | ╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝ |
          |                                                                    |
          +--------------------------------------------------------------------+

                                                            Made by @RP


        ";
        using (StringReader reader = new StringReader(banner))
        {
            string line = string.Empty;
            do
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
                    Console.WriteLine(line);
                }
            }while (line != null);
        }
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
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Remove a Task"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"                                    r\n"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Quit"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write($"                                             q\n"); Console.ResetColor();
        Console.WriteLine();
    }
}