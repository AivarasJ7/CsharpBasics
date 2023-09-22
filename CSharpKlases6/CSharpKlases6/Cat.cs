using System.Drawing;

namespace CSharpKlases6
{
    // Tada sukurkite paveldėtas klases Dog ir Cat, kurios prideda papildomas savybes, tokias kaip Breed ir Color atitinkamai, bei perrašo MakeSound() metodą.
    // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
    public class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color, bool likesMilk) : base(name, age)
        {
            Breed = breed;
            Color = color;
            LikesMilk = likesMilk;
        }

        public string Breed { get; }
        public string Color { get; }
        public bool LikesMilk { get; }

        public string GetCatInfo()
        {
            return $"Veisle: {Breed}, Spalva: {Color}, Megsta piena: {LikesMilk}";
        }

        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
