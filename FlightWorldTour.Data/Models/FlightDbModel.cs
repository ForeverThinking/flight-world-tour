namespace FlightWorldTour.Data.Models;

public sealed class FlightDbModel
{
    public Guid Id { get; set; }
    public AirportDbModel? Origin { get; set; } = null;
    public AirportDbModel? Destination { get; set; } = null;
    public double Distance { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime Type { get; set; }
    public DateTime Duration { get; set; }
}