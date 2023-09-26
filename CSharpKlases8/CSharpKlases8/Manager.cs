namespace CSharpKlases8
{
    public class Manager : Employee
    {
        // Tada sukurkite paveldėtą klasę Manager su papildoma savybe NumberOfSubordinates ir papildomu metodu PrintManagerInfo(),
        // kuris išveda informaciją apie vadovą. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Manager(string name, string jobTitle, decimal salary, int numberOfSubordinates) : base(name, jobTitle, salary)
        {
            NumberOfSubordinates = numberOfSubordinates;
        }

        public decimal NumberOfSubordinates { get; }

        public string PrintManagerInfo()
        {
            return $"Darbuotojo vardas yra {Name}, jo pareigos yra {JobTitle}, jo atlyginimas yra {Salary} ir jis turi {NumberOfSubordinates} pavaldiniu.";
        }
    }
}
