namespace FlightWorldTour.Core.Entities;

public record AirportBusinessModel(
    string IcaoReference,
    string AirportName,
    string Country,
    double Latitude,
    double Longitude);