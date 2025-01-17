namespace FlightWorldTour.Data.Models;

public sealed class AirportDbModel
{
    public Guid Id { get; set; }
    public string IcaoReference { get; set; } = string.Empty;
    public string AirportName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}