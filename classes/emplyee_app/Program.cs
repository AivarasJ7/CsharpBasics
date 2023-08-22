namespace emplyee_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesFromFile = GetEmployeesFromFile("data.csv");

            foreach (Employee employee in employeesFromFile)
            {
                Console.WriteLine("Spausdinu employees:");
                Console.WriteLine($"Darbuotojo vardas: {employee.Name}");
                Console.WriteLine($"Darbuotojo pavarde: {employee.Surname}");
                Console.WriteLine($"Darbuotojo ID: {employee.Id}");
                Console.WriteLine($"Darbuotojo Gimimo data :{employee.DateOfBirth}");
                Console.WriteLine();
            }
        }

        private static List<Employee> GetEmployeesFromFile(string path)
        {
            List<Employee> employees = new List<Employee>();

            using StreamReader reader = new StreamReader(path);

            reader.ReadLine(); // name;surname;employee_id;date_of_birth

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] splitLines = line.Split(';');

                Employee employee = new Employee();

                employee.Name = splitLines[0];
                employee.Surname = splitLines[1];
                employee.Id = splitLines[2];
                employee.DateOfBirth = DateTime.Parse(splitLines[3]);

                employees.Add(employee);
            }

            return employees;
        }
    }
}