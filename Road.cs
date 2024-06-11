using System.Text;

namespace Oscar;

public class Road
{
    public uint Id { get; }
    public string WhereTo { get; set; }
    public string FromTo { get; set; }
    public DateTime TravelDate { get; set; }

    public Road(uint id, string whereTo, string fromTo, DateTime travelDate)
    {
        Id = id;
        WhereTo = whereTo;
        FromTo = fromTo;
        TravelDate = travelDate;
    }

    public override string ToString()

    {
       
        return $"{Id}, {WhereTo}, {FromTo}, {TravelDate}";
        
    }
}