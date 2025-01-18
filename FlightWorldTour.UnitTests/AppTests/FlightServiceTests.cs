using FakeItEasy;
using FlightWorldTour.App;
using FlightWorldTour.Core.Entities;
using FlightWorldTour.Core.Interfaces;
using FluentAssertions;

namespace FlightWorldTour.UnitTests.AppTests;

public class FlightServiceTests
{
    private readonly FlightService _flightService;
    private readonly IFlightRepository _repoFake = A.Fake<IFlightRepository>();
    
    public FlightServiceTests()
    {
        _flightService = new FlightService(_repoFake);
    }

    [Fact]
    public async Task GetLastFlight_Called_ReturnsCorrectData()
    {
        // Arrange
        var flightData = new LastFlightRecord(
            OriginAirportName: "Heathrow",
            OriginCountry: "England",
            DestinationAirportName: "Schiphol",
            DestinationCountry: "Netherlands");

        A.CallTo(() => _repoFake.GetLastFlightAsync()).Returns(flightData);
        
        // Act
        var result = await _flightService.GetLastFlightAsync();
        
        // Assert
        result.Should().Be(flightData);
    }
}