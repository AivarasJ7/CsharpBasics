namespace CSharpKlases10
{
    public class Computer
    {
        // Kompiuterių klasės: Sukurkite pagrindinę Computer klasę su savybėmis Brand ir Model ir metodu PrintComputerInfo(),
        // kuris išveda visą informaciją apie kompiuterį.

        public Computer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; }
        public string Model { get; }

        public void PrintComputerInfo()
        {
            Console.WriteLine($"Prekes zenklas: {Brand}, Modelis: {Model}.");
        }
    }
}