namespace Oscar;

public class Feedback
{
    public  uint Id { get; }
    public string Title { get; }
    public string Description { get; }
    


    public Feedback(uint id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        
    }

    public override string ToString()
    {
        return $"{Id}, {Title}, {Description}";
    }
}