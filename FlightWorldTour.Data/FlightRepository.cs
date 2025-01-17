using FlightWorldTour.Core.Entities;
using FlightWorldTour.Core.Interfaces;

namespace FlightWorldTour.Data;

public class FlightRepository : IFlightRepository
{
    public FlightBusinessModel GetSingleFlight(Guid id)
    {
        throw new NotImplementedException();
    }

    public ICollection<FlightBusinessModel> GetAllFlights()
    {
        throw new NotImplementedException();
    }

    public void AddFlight(FlightBusinessModel flight)
    {
        throw new NotImplementedException();
    }

    public void AmendFlight(FlightBusinessModel flight)
    {
        throw new NotImplementedException();
    }

    public void DeleteFlight(Guid id)
    {
        throw new NotImplementedException();
    }
}