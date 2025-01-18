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
    public void GetLastFlight_Called_ReturnsCorrectData()
    {
        // Arrange
        var flightData = new LastFlightRecord(
            OriginAirportName: "Heathrow",
            OriginCountry: "England",
            DestinationAirportName: "Schiphol",
            DestinationCountry: "Netherlands");

        A.CallTo(() => _repoFake.GetLastFlight()).Returns(flightData);
        
        // Act
        var result = _flightService.GetLastFlight();
        
        // Assert
        result.Should().Be(flightData);
    }
}