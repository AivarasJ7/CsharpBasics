namespace CSharpKlases15_1
{
    public class Cat : Animal
    {
        // Tada sukurkite klases "Šuo" ir "Katinas", kurios paveldės "Gyvūnas" klasę ir perrašys "Garsas" metodą.
        // Kiekvienoje "Šuo" ir "Katinas" klasėse "Garsas" metodas turėtų naudoti "vardas" savybę

        public Cat(string name) : base(name)
        {

        }

        public override string MakeASound()
        {
            return $"Tai yra katinas kurio vardas {Name} ir jis sako meow";
        }
    }
}
