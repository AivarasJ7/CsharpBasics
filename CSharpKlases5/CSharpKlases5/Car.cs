namespace CSharpKlases5
{
    // Tada sukurkite paveldėtą Car klasę su papildoma savybe NumberOfSeats ir papildomu metodu PrintCarInfo(), kuris išveda informaciją apie automobilį.
    public class Car : Vehicle
    {
        public Car(string brand, string model, int year, int numberOfSeats) : base(brand, model, year)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get; }

        public string PrintCarInfo()
        {
            return $"Automobilio marke yra {Brand}, jos modelis yra {Model}, ji buvo pagaminta {Year} ir ji turi {NumberOfSeats} sedejimo vietu.";
        }
    }
}
