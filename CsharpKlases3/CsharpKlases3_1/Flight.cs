

namespace CsharpKlases3_1
{
    public class Flight
    {
        // 1. Sukurkite klasę, kuri aprašo skrydį (Flight) iš vieno miesto į kitą. Klasę sudaro tokios sąvybės:
        // - iš kur skrisime, miesto/oro uosto trumpinys iš trijų raidžių(IATA, detaliau: https://www.nationsonline.org/oneworld/IATA_Codes/airport_code_list.htm#:~:text=The%20International%20Air%20Transport%20Association's,it%2C%20New%20York's%20John%20F.) pvz. VNO
        // - kur skrisime (tas pats IATA) pvz.STO
        // - pakilimo data ir laikas
        // - nusileidimo data ir laikas
        // - kaina 
        // - valiuta
        // - skrydžio numeris
        // - klasė(Economy, Business)
        // - klasė turi turėti metodą GetFlightInfo, kuris grąžina formatuotą informaciją apie skrydį.

        //savybes - properties (public)
        public string DepartureCity;
        public string ArrivalCity;
        public DateTime DepartureDateTime;
        public DateTime ArrivalDateTime;
        public decimal Price;
        public string Currency;
        public string FlightNumber;
        public string Class;

        public string GetFlightInfo()
        {
            return $"Skrydis {FlightNumber}: {DepartureCity} ({DepartureDateTime}) -> {ArrivalCity} ({ArrivalDateTime})\n" +
                   $"Klasė: {Class}\n" +
                   $"Kaina: {Price} {Currency}";
        }
    }
}
