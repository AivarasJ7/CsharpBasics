namespace CSharpKlases8
{
    public class Employee
    {
        // Darbuotojų klasės: Sukurkite bazinę klasę Employee su savybėmis Name, JobTitle ir Salary ir metodu PrintEmployeeInfo(),
        // kuris išveda visą informaciją apie darbuotoją.

        public Employee(string name, string jobTitle, decimal salary)
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
        }

        public string Name { get; }
        public string JobTitle { get; }
        public decimal Salary { get; }

        public string PrintEmployeeInfo()
        {
            return $"Darbuotojo vardas yra {Name}, jo pareigos yra {JobTitle} ir jo atlyginimas yra {Salary}.";
        }
    }
}
