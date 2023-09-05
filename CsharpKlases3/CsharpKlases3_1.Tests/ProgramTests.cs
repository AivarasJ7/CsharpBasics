namespace CsharpKlases3_1.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CallingFindFlightsByIATWithListReturns1()
        {
            // Arrange
            List<Flight> flights = new List<Flight>
            {
                new Flight
                {
                    DepartureCity = "VNO",
                    ArrivalCity = "STO"
                },
            };

            // Act
            List<Flight> filteredFlights = Program.FindFlightsByIATA(flights, "VNO", "STO");

            // Assert
            Assert.AreEqual(1, filteredFlights.Count);
        }
    }
}