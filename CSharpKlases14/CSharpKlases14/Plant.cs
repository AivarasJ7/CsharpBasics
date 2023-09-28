namespace CSharpKlases14
{
    public class Plant
    {
        // Augalų klasės: Sukurkite bazinę klasę Plant su savybėmis Species ir Height ir metodu PrintPlantInfo(), kuris išveda visą informaciją apie augalą.

        public Plant(string species, int height)
        {
            Species = species;
            Height = height;
        }

        public string Species { get; }
        public int Height { get; }

        public string PrintPlantInfo()
        {
            return $"Augalo rusis: {Species}, aukstis: {Height} cm.";
        }
    }
}