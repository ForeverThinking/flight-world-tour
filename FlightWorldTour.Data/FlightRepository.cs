using FlightWorldTour.Core.Entities;
using FlightWorldTour.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FlightWorldTour.Data;

public class FlightRepository(ApplicationDbContext context) : IFlightRepository
{
    public async Task<LastFlightRecord?> GetLastFlightAsync() =>
        await context.Flights
            .OrderByDescending(fl => fl.FlightAdded)
            .Select(fl => new LastFlightRecord(
                fl.Origin.AirportName,
                fl.Origin.Country,
                fl.Destination.AirportName,
                fl.Destination.Country))
            .FirstOrDefaultAsync();

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