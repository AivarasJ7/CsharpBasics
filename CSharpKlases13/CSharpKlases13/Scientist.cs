namespace CSharpKlases13
{
    public class Scientist
    {
        // Mokslininkų klasės: Sukurkite pagrindinę Scientist klasę su savybėmis Name ir FieldOfStudy ir metodu PrintScientistInfo(),
        // kuris išveda visą informaciją apie mokslininką.

        public Scientist(string name, string fieldOfStudy)
        {
            Name = name;
            FieldOfStudy = fieldOfStudy;
        }

        public string Name { get; }
        public string FieldOfStudy { get; }

        public void PrintScientistInfo()
        {
            Console.WriteLine($"Vardas: {Name}, studiju srytis: {FieldOfStudy}");
        }
    }
}