// See https://aka.ms/new-console-template for more information

using Oscar;
public class Program
{
    public static void Main(string[] args)
    {
        Car opel = new Car("abc123", "Astra", "Opel", 4);
        Person person = new Person(1, "Jani");
        person.Type = OscarType.Driver;
        Road road = new Road(1, "Pécs", "Budapest", DateTime.Now);
        Registration registration = new Registration(1, road, person);

        OscarServiceProvider oscarServiceProvider = new OscarServiceProvider();
        
        oscarServiceProvider.Registrate(registration, opel);
        Person p = new Person(2, "Gizi");
        oscarServiceProvider.ReserveSeat(p, 1);
        oscarServiceProvider.ShowInfo();
        
        //oscarServiceProvider.Search("ibi");
        
        
        
        
    }
}