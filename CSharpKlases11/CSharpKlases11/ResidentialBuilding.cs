namespace CSharpKlases11
{
    public class ResidentialBuilding : Building
    {
        // Tada sukurkite paveldėtą klasę ResidentialBuilding su papildoma savybe NumberOfApartments ir papildomu metodu PrintResidentialBuildingInfo(),
        // kuris išveda informaciją apie gyvenamąjį namą. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public ResidentialBuilding(string address, int numberOfFloors, int numberOfApartments) : base(address, numberOfFloors)
        {
            NumberOfApartments = numberOfApartments;
        }

        public int NumberOfApartments { get; }

        public void PrintResidentialBuildingInfo()
        {
            Console.WriteLine($"Adresas: {Address}, aukstu skaicius: {NumberOfFloors}, butu skaicius: {NumberOfApartments}");
        }
    }
}