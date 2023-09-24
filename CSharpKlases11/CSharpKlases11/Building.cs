namespace CSharpKlases11
{
    public class Building
    {
        // Statinių klasės: Sukurkite bazinę klasę Building su savybėmis Address ir NumberOfFloors ir metodu PrintBuildingInfo(),
        // kuris išveda visą informaciją apie pastatą.

        public Building(string address, int numberOfFloors)
        {
            Address = address;
            NumberOfFloors = numberOfFloors;
        }

        public string Address { get; }
        public int NumberOfFloors { get; }

        public void PrintBuildingInfo()
        {
            Console.WriteLine($"Adresas: {Address}, Aukstu skaicius: {NumberOfFloors}");
        }
    }
}