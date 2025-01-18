using FlightWorldTour.Core.Entities;

namespace FlightWorldTour.Core.Interfaces;

public interface IFlightService
{
    LastFlightRecord GetLastFlight();
    FlightBusinessModel GetSingleFlight();
    ICollection<FlightBusinessModel> GetAllFlights();
    FlightBusinessModel AddFlight(FlightBusinessModel flight);
    FlightBusinessModel AmendFlight(FlightBusinessModel flight);
    void DeleteFlight(Guid id);
}