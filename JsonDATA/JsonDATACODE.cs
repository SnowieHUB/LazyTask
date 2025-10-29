using System.Text.Json;

namespace LazyTask.JsonDATA;

public class ItemsTask
{
    public int TaskId { get; set; }
    public enum Status {New = 0, Active = 1, All_Most_Done = 2, Done = 3, Archived = 4 }
    public enum Priority {Low = 0, Medium = 1, High = 2 }
    public string TaskName {get; set;}
    public string? TaskDescription {get; set;}
    public string CreatedAt {get; set;}
    public DateTime DueDate { get; set; } = DateTime.Now;
}
public class JsonDATACODE
{
    public static void JsonFunction()
    {
        var itemTask = new ItemsTask
        {
            // TaskId = TODO
            // Staus = TODO
            // Priority = TODO
            // TaskName = TODO
            // TaskDescription? = TODO
            // CreatedAt = TODO
            // DueDate? = TODO
        };
        
        var options = new JsonSerializerOptions{ WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(itemTask, options);
        
        Console.WriteLine(jsonString);
    }
}