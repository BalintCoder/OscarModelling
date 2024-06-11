using System.Text;

namespace Oscar;

public class Registration
{
    public uint Id { get; }
    public Road Trip { get; }
    public Person Owner { get; }
    private List<Person> _reservations = new();

    public Registration(uint id, Road trip, Person owner)
    {
        Id = id;
        Trip = trip;
        Owner = owner;
    }

    public void Reserve(Person person)
    {
        _reservations.Add(person);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override bool Equals(Object obj)
    {
        Registration r = (Registration)obj;
        return Id == r.Id && Trip.Id == r.Trip.Id && Owner.Id == r.Owner.Id;
    }

    public override string ToString()
    {
        StringBuilder builder = new();
        foreach (var person in _reservations)
        {
            builder.Append(person);
        }
        
        
        return $"{Id}, {Trip}, {Owner}, {builder}";
    }

    public int GetTravellerCount()
    {
        return _reservations.Count;
    }
}