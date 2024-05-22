namespace WPFWhatToDo;

public class TaskViewModel
{
    public String Title { get; set; }
    public String Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ValidUntil { get; set; }
    public TaskViewModel(String Title, String Description, DateTime CreatedAt, DateTime ValidUntil)
    {
        this.Title = Title;
        this.Description = Description;
        this.CreatedAt = CreatedAt;
        this.ValidUntil = ValidUntil;
    }
}
