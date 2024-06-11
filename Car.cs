namespace Oscar;

public class Car
{
    public  string Plate { get; }
    public string Type { get; }
    public string Brand { get; }
    public uint Seats { get; }


    public Car(string plate, string type, string brand, uint seats)
    {
        Plate = plate;
        Type = type;
        Brand = brand;
        Seats = seats;
    }

    public override string ToString()
    {
        return $"{Plate}, {Type}, {Brand}, {Seats}";
    }
        
}