using System.Text;

namespace Oscar;

public class Person
{
    public uint Id { get; }
    public string Name { get; }
    public List<Feedback> Feedbacks { get; set; }
    public OscarType Type { get; set; }


    public Person(uint id, string name)
    {
        Id = id;
        Name = name;
        Feedbacks = new();
    }

    public override string ToString()
    {
        StringBuilder builder = new();
        foreach (var feedback in Feedbacks)
        {
            builder.Append(feedback);
        }
        return $"{Id}, {Name}, {Type}, {builder}";
    }
}