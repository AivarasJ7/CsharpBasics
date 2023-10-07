namespace CSharpKlases14
{
    public class Flower : Plant
    {
        // Tada sukurkite paveldėtą klasę Flower su papildoma savybe Color ir papildomu metodu PrintFlowerInfo(), kuris išveda informaciją apie gėlę.
        // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Flower(string species, int height, string color) : base(species, height)
        {
            Color = color;
        }

        public string Color { get; }

        public string PrintFlowerInfo()
        {
            return $"Augalo rusis: {Species}, aukstis: {Height} cm, spalva {Color}.";
        }
    }
}