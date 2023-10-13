namespace CSharpKlases15_2
{
    public abstract class Figure
    {
        // Užduotis 2:
        // Sukurkite bazinę klasę "Figūra" su protected savybe "spalva".

        public Figure(string color)
        {
            Color = color;
        }

        protected string Color { get; }

        public abstract string Draw();
    }
}
