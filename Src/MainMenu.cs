using System.Globalization;
using System.Text;
using SmallFunctions;
using LazyTask;

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

        Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                return;
            case "s":
                ShowList();
                return;
            case "r":
                RemoveTask();
                return;
            case "q":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nDo you want to quit? [Y/N]");
                Console.ResetColor();
                break;
        }
    }

    public static void AddnewTask()
    {
        Console.Clear();
        string Taskpage = $"=== Add new Task ===";
        string taskguide = "To skip adding task just press enter.";
        Console.SetCursorPosition((Console.WindowWidth - Taskpage.Length) / 2, Console.CursorTop);
        Console.WriteLine(Taskpage);
        Console.SetCursorPosition((Console.WindowWidth - taskguide.Length) / 2, Console.CursorTop);
        Console.WriteLine(taskguide);
        bool loop = true;
        while (loop)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - 5, Console.CursorTop);
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                loop = false;
                break;
            }
            Program.taskitems.Add(input);
            Console.WriteLine($"Do you want to add another task? [Y/N]");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "n")
            {
                Console.WriteLine($"Task(s) has been added.");
                Smallfunc.Delay2S();
                loop = false;
            }
        }
        Console.WriteLine("Press Enter to continue...");
    }
    public static void RemoveTask()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;        
        string removeTaskbanner = $"=== Remove Task ===";
        Console.SetCursorPosition((Console.WindowWidth - removeTaskbanner.Length) / 2, Console.CursorTop);
        Console.WriteLine(removeTaskbanner);
        
        foreach (string taskname in Program.taskitems)
        {
            int icount = Program.taskitems.IndexOf(taskname);
            icount++;
            Console.SetCursorPosition((Console.WindowWidth - taskname.Length - icount - 1) / 2, Console.CursorTop);
            Console.WriteLine($"[{icount}] {taskname}");
        }

        Console.WriteLine();
        string removeguide = $"Give a number that task you want to be removed.";
        Console.SetCursorPosition((Console.WindowWidth - removeguide.Length) / 2, Console.CursorTop);
        Console.WriteLine(removeguide);
        string skipRemove = "To skip removing task press 0.";
        Console.SetCursorPosition((Console.WindowWidth - skipRemove.Length) / 2, Console.CursorTop);
        Console.WriteLine(skipRemove);
        Console.SetCursorPosition((Console.WindowWidth / 2) - 1, Console.CursorTop);
        
        for (int i = 0; i < Program.taskitems.Count; i++)
        {
            int removeNumber;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (int.TryParse(Console.ReadLine(), out removeNumber))
            {
                if (removeNumber == 0)
                {
                    break;
                }
                var idx = removeNumber - 1;
                string selected =  Program.taskitems[idx];
                string taskSelected = $"Do you want to remove [{selected}]? [y/n]";                
                Console.SetCursorPosition((Console.WindowWidth - taskSelected.Length) / 2, Console.CursorTop);
                Console.WriteLine(taskSelected);
                string answer =  Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Program.taskitems.Remove(selected);
                }
            }
            else
            {
                String invalidNumber = "Invalid number";
                Console.SetCursorPosition((Console.WindowWidth - invalidNumber.Length) / 2, Console.CursorTop);
                Console.WriteLine(invalidNumber);
            }
            break;
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ResetColor();
    }

    public static void ShowList()
    {
        Console.Clear();
        string showTasks = $"=== Show Tasks ===";
        Console.SetCursorPosition((Console.WindowWidth - showTasks.Length) / 2, Console.CursorTop);
        Console.WriteLine(showTasks);
        foreach (var task in Program.taskitems)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth - task.Length) / 2, Console.CursorTop);
            Console.WriteLine(task);
        }
        Console.WriteLine("Press Enter to continue...");
    }
    public static void PrintMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(String.Format("{0, 35}", "Add new Task"));
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(String.Format("{0, 35}", "n"));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(String.Format("{0, 34}", "Remove Task"));
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(String.Format("{0, 36}", "r"));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(String.Format("{0, 32}", "Show List"));
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(String.Format("{0, 38}", "s"));
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(String.Format("{0, 27}","Quit"));
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(String.Format("{0, 43}", "q"));
        Console.WriteLine();

        
        
        Console.ResetColor();
    }
}