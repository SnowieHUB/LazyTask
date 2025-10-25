namespace MiniGameProjest;

public class minigame
{
    public static void gamemenu()
    {
        string menu = $"=== Game Menu ===";
        Console.SetCursorPosition((Console.WindowWidth - menu.Length) / 2 , Console.CursorTop);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(menu);
        Console.ForegroundColor = ConsoleColor.White;
        string gameGuide = $"Guess the word.";
        Console.SetCursorPosition((Console.WindowWidth - gameGuide.Length) / 2, Console.CursorTop);
        Console.Write(gameGuide);
    }
}