namespace CSharpKlases6
{
    // Tada sukurkite paveldėtas klases Dog ir Cat, kurios prideda papildomas savybes, tokias kaip Breed ir Color atitinkamai, bei perrašo MakeSound() metodą.
    // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
    public class Dog : Animal
    {
        public Dog(string name, int age, string breed, string color, bool isPoliceDog) : base(name, age)
        {
            Breed = breed;
            Color = color;
            IsPoliceDog = isPoliceDog;
        }

        public string Breed { get; }
        public string Color { get; }
        public bool IsPoliceDog { get; }

        public string GetAnimalInfo()
        {
            return $", Veisle: {Breed}, Spalva: {Color}, Yra policijos suo: {IsPoliceDog}";
        }

        public override string MakeSound()
        {
            return "Woof!";
        }

    }
}
