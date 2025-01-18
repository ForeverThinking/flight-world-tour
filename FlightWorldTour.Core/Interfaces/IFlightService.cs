using FlightWorldTour.Core.Entities;

namespace FlightWorldTour.Core.Interfaces;

public interface IFlightService
{
    Task<LastFlightRecord?> GetLastFlightAsync();
    FlightBusinessModel GetSingleFlight();
    ICollection<FlightBusinessModel> GetAllFlights();
    FlightBusinessModel AddFlight(FlightBusinessModel flight);
    FlightBusinessModel AmendFlight(FlightBusinessModel flight);
    void DeleteFlight(Guid id);
}