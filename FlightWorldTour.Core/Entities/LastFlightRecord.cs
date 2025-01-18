namespace FlightWorldTour.Core.Entities;

public record LastFlightRecord(
    string OriginAirportName,
    string OriginCountry,
    string DestinationAirportName,
    string DestinationCountry);