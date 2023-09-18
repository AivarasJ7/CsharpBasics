
namespace CSharpKlases6
{
    // Gyvūnų klasės: Sukurkite bazinę klasę Animal su savybėmis Name ir Age ir metodu MakeSound(), kuris imituoja gyvūno garsą.
    public class Animal
    {
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public virtual string GetAnimalInfo()
        {
            return $"Vardas: {Name}, metai: {Age}";
        }

        public virtual string MakeSound()
        {
            return "Imituojamas gyvuno garsas";
        }
    }
}
