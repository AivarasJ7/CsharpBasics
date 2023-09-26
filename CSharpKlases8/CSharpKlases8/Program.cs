namespace CSharpKlases8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Darbuotojų klasės: Sukurkite bazinę klasę Employee su savybėmis Name, JobTitle ir Salary ir metodu PrintEmployeeInfo(),
            // kuris išveda visą informaciją apie darbuotoją.
            // Tada sukurkite paveldėtą klasę Manager su papildoma savybe NumberOfSubordinates ir papildomu metodu PrintManagerInfo(),
            // kuris išveda informaciją apie vadovą. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Sveiki!");

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("1 - Prideti nauja darbuotoja");
                Console.WriteLine("2 - Prideti nauja vadova");
                Console.WriteLine("3 - Rodyti darbuotoju ir vadovu informacija");
                Console.WriteLine("4 - Iseiti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee newEmployee = AddNewEmployee();
                        employees.Add(newEmployee);
                        break;

                    case 2:
                        Manager newManager = AddNewManager();
                        employees.Add(newManager);
                        break;

                    case 3:
                        DisplayEmployeeAndManagerInfo(employees);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar karta.");
                        break;
                }
            }
        }

        static Employee AddNewEmployee()
        {
            Console.WriteLine("Iveskite darbuotojo varda:");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite darbuotojo pareigas:");
            string jobTitle = Console.ReadLine();

            Console.WriteLine("Iveskite darbuotojo atlyginima:");
            decimal salary = decimal.Parse(Console.ReadLine());

            return new Employee(name, jobTitle, salary);
        }

        static Manager AddNewManager()
        {
            Console.WriteLine("Iveskite vadovo varda:");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite vadovo pareigas:");
            string jobTitle = Console.ReadLine();

            Console.WriteLine("Iveskite vadovo atlyginima:");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite pavaldiniu skaičiu:");
            int numberOfSubordinates = int.Parse(Console.ReadLine());

            return new Manager(name, jobTitle, salary, numberOfSubordinates);
        }

        static void DisplayEmployeeAndManagerInfo(List<Employee> employees)
        {
            Console.WriteLine("Darbuotoju ir vadovu Informacija:");
            foreach (Employee employee in employees)
            {
                if (employee is Manager manager)
                {
                    Console.WriteLine(manager.PrintManagerInfo());
                }
                else
                {
                    Console.WriteLine(employee.PrintEmployeeInfo());
                }
            }
        }
    }
}