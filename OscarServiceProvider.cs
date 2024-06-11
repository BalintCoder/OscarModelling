namespace Oscar;

public class OscarServiceProvider
{
    private Dictionary<Registration, Car> _registrations = new();

    public void Registrate(Registration registration, Car car)
    {
        if (!_registrations.ContainsKey(registration))
        {
            _registrations.Add(registration, car);
        }
        else
        {
            _registrations[registration] = car;
        }
    }

    public void ShowInfo()
    {
        foreach (var item in _registrations)
        {
            Console.WriteLine($"{item.Key}, {item.Value}");
        }
    }

    public void Search(string pattern)
    {
        var results = _registrations.Where(x => x.Key.ToString().Contains(pattern) ||
                                                x.Value.ToString().Contains(pattern));

        foreach (var result in results)
        {
            Console.WriteLine($"{result.Key}, {result.Value}");
        }
    }

    public void ReserveSeat(Person person, uint id)
    {
        if (_registrations.Any(x => x.Key.Id == id))
        {
            Registration reg = _registrations.Where(x => x.Key.Id == id).First().Key;
            Car car = _registrations.Where(x => x.Key.Id == id).First().Value;

            if (car.Seats > reg.GetTravellerCount())
            {
            reg.Reserve(person);
                
            }
            else
            {
                Console.WriteLine("Could not be reserved");
            }
            
        }
        else
        {
            Console.WriteLine("No registration found");
        }
    }
}