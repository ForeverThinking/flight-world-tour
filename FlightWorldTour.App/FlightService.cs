using FlightWorldTour.Core.Entities;
using FlightWorldTour.Core.Interfaces;

namespace FlightWorldTour.App;

public class FlightService(IFlightRepository repository) : IFlightService
{
    public LastFlightRecord GetLastFlight() => repository.GetLastFlight();

    public FlightBusinessModel GetSingleFlight()
    {
        throw new NotImplementedException();
    }

    public ICollection<FlightBusinessModel> GetAllFlights()
    {
        throw new NotImplementedException();
    }

    public FlightBusinessModel AddFlight(FlightBusinessModel flight)
    {
        throw new NotImplementedException();
    }

    public FlightBusinessModel AmendFlight(FlightBusinessModel flight)
    {
        throw new NotImplementedException();
    }

    public void DeleteFlight(Guid id)
    {
        throw new NotImplementedException();
    }
}