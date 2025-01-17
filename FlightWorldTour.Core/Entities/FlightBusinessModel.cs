namespace FlightWorldTour.Core.Entities;

public record FlightBusinessModel(
    AirportBusinessModel Origin,
    AirportBusinessModel Destination,
    double Distance,
    DateTime StartTime,
    DateTime EndTime,
    DateTime Duration);