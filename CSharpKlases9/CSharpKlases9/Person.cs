namespace CSharpKlases9
{
    public class Person
    {
        // Asmenų klasės: Sukurkite pagrindinę Person klasę su savybėmis Name ir Age ir metodu PrintPersonInfo(),
        // kuris išveda visą informaciją apie asmenį.

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public string PrintPersonInfo()
        {
            return $"Vardas: {Name}, Metai: {Age}.";
        }
    }
}
