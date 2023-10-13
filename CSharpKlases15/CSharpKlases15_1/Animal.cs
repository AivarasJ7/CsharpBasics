namespace CSharpKlases15_1
{
    public abstract class Animal
    {
        // Užduotis 1:
        // Sukurkite klasę "Gyvūnas" su protected savybe "vardas".

        public Animal(string name)
        {
            Name = name;
        }

        protected string Name { get; }

        public abstract string MakeASound();
    }
}
