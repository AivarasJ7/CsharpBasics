namespace CsharpKlases3_1
{
    public class Program
    {
        // 2. Sukurkite metodą ar metodus kurie nuskaito iš failo duomenis ir užpildo skrydžią sąrašą (List).
        // Failą sugalvokite patys pagal duotą klasės aprašymą. faile turi būti bent keli skrydžiai. 
        // Galutinis rezultatas šio punkto turi būti List<Flight> užpildytas skrydžiais.

        static void Main(string[] args)
        {
            List<Flight> flights = ReadFlightsFromFile("skrydziai.txt");

            foreach (Flight flight in flights)
            {
                Console.WriteLine(flight.GetFlightInfo());
                Console.WriteLine();
            }
        }

        public static List<Flight> ReadFlightsFromFile(string fileName)
        {
            List<Flight> flights = new List<Flight>();

            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] data = line.Split(' ');

                    Flight flight = new Flight
                    {
                        DepartureCity = data[0],
                        ArrivalCity = data[1],
                        DepartureDateTime = DateTime.Parse($"{data[2]} {data[3]}"),
                        ArrivalDateTime = DateTime.Parse($"{data[4]} {data[5]}"),
                        Price = decimal.Parse(data[6]),
                        Currency = data[7],
                        FlightNumber = data[8],
                        Class = data[9]
                    };

                    flights.Add(flight);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Klaida skaitant faila: " + ex.Message);
            }

            return flights;
        }
    }
}