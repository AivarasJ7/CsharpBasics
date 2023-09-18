namespace CSharpKlases5
{
    public class Vehicle
    {
        // Transporto priemonių klasės: Sukurkite pagrindinę Vehicle klasę su savybėmis Brand, Model ir Year ir metodu PrintInfo(),
        // kuris išveda visą informaciją apie transporto priemonę.

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            
        }

        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }

        public string PrintInfo()
        {
            return $"Transporto priemones marke yra {Brand}, jos modelis yra {Model} ir ji buvo pagaminta {Year} metais.";
        }



    }
}
