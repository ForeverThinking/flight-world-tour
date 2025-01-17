using FlightWorldTour.Core.Entities;

namespace FlightWorldTour.Core.Interfaces;

public interface IFlightService
{
    FlightBusinessModel GetSingleFlight();
    ICollection<FlightBusinessModel> GetAllFlights();
    FlightBusinessModel AddFlight(FlightBusinessModel flight);
    FlightBusinessModel AmendFlight(FlightBusinessModel flight);
    void DeleteFlight(Guid id);
}