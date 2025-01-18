using FlightWorldTour.Core.Entities;

namespace FlightWorldTour.Core.Interfaces;

public interface IFlightRepository
{
    LastFlightRecord GetLastFlight();
    FlightBusinessModel GetSingleFlight(Guid id);
    ICollection<FlightBusinessModel> GetAllFlights();
    void AddFlight(FlightBusinessModel flight);
    void AmendFlight(FlightBusinessModel flight);
    void DeleteFlight(Guid id);
}