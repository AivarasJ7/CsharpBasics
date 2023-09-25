namespace CSharpKlases13
{
    public class Physicist : Scientist
    {
        // Tada sukurkite paveldėtą klasę Physicist su papildoma savybe Specialization ir papildomu metodu PrintPhysicistInfo(),
        // kuris išveda informaciją apie fiziką. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Physicist(string name, string fieldOfStudy, string specialization) : base(name, fieldOfStudy)
        {
            Specialization = specialization;
        }

        public string Specialization { get; }

        public void PrintPhysicistInfo()
        {
            Console.WriteLine($"Vardas: {Name}, studiju srytis: {FieldOfStudy}, specilizacija {Specialization}");
        }
    }
}