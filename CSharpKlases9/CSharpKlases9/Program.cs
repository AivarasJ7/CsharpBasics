namespace CSharpKlases9
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Asmenų klasės: Sukurkite pagrindinę Person klasę su savybėmis Name ir Age ir metodu PrintPersonInfo(),
            // kuris išveda visą informaciją apie asmenį.
            // Tada sukurkite paveldėtas klases Student ir Teacher su papildomomis savybėmis,
            // tokiais kaip GradeLevel ir Subject atitinkamai, bei papildomais metodais PrintStudentInfo() ir PrintTeacherInfo(),
            // kurie išveda informaciją apie mokinį ar mokytoją. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė, 
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            List<Person> people = new List<Person>();

            Console.WriteLine("Sveiki!");

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("1 - Prideti nauja asmeni");
                Console.WriteLine("2 - Prideti nauja mokini");
                Console.WriteLine("3 - Prideti nauja mokytoja");
                Console.WriteLine("4 - Rodyti informacija");
                Console.WriteLine("5 - Iseiti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNewPerson(people);
                        break;

                    case 2:
                        AddNewStudent(people);
                        break;

                    case 3:
                        AddNewTeacher(people);
                        break;

                    case 4:
                        DisplayPersonInfo(people);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Neteisingas pasirinkimas. Prasome bandykite dar karta.");
                        break;
                }
            }
        }

        static void AddNewPerson(List<Person> people)
        {
            Console.WriteLine("Iveskite varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite amziu:");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);
            people.Add(person);
        }

        static void AddNewStudent(List<Person> people)
        {
            Console.WriteLine("Iveskite varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite amziu:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite klases lygi:");
            string gradeLevel = Console.ReadLine();

            Student student = new Student(name, age, gradeLevel);
            people.Add(student);
        }

        static void AddNewTeacher(List<Person> people)
        {
            Console.WriteLine("Iveskite varda:");
            string name = Console.ReadLine();
            Console.WriteLine("Iveskite amziu:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite tema:");
            string subject = Console.ReadLine();

            Teacher teacher = new Teacher(name, age, subject);
            people.Add(teacher);
        }

        static void DisplayPersonInfo(List<Person> people)
        {
            Console.WriteLine("Informacija apie asmenis:");
            foreach (Person person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine(student.PrintStudentInfo());
                }
                else if (person is Teacher teacher)
                {
                    Console.WriteLine(teacher.PrintTeacherInfo());
                }
                else
                {
                    Console.WriteLine(person.PrintPersonInfo());
                }
            }
        }
    }
}