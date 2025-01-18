using FlightWorldTour.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FlightWorldTour.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public DbSet<AirportDbModel> Airports { get; set; }
    public DbSet<FlightDbModel> Flights { get; set; }
}