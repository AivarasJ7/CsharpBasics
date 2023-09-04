namespace classes_constructors_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmo studento varda:");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite pirmo studento pavarde:");
            string surname = Console.ReadLine();

            Console.WriteLine("Iveskite gatve:");
            string street = Console.ReadLine();

            Console.WriteLine("Iveskite namo nr.:");
            int houseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite buto nr.:");
            int flatNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite sali:");
            string country = Console.ReadLine();

            Console.WriteLine("Iveskite miesta:");
            string city = Console.ReadLine();

            Console.WriteLine("Iveskite lyti 1- Other, 2-Male, 3-Female:");
            int gender = int.Parse(Console.ReadLine());

            Adress studentAdress = new Adress(
                street, 
                flatNumber, 
                houseNumber, 
                city, 
                country
                );

            Student student1 = new Student(
                name, 
                surname, 
                studentAdress,
                (Gender)gender);

            Console.WriteLine("Iveskite antro studento varda:");
            name = Console.ReadLine();

            Console.WriteLine("Iveskite antro studento pavarde:");
            surname = Console.ReadLine();

            Console.WriteLine("Iveskite antro studento amziu:");
            int age = int.Parse(Console.ReadLine());

            Student student2 = new Student(name, surname, age);

            Console.WriteLine($"Pirmas studentas: {student1.Name} {student1.Surname}");
            Console.WriteLine($"Pirmojo studento adresas: {student1.Adress}");
            Console.WriteLine($"Antras studentas: {student2.Name} {student2.Surname}");

            // problema kai nenaudoji konstruktoriaus/enkapsuliacijos.

            //Student student1 = new Student();
            //Student student2 = new Student();

            //Console.WriteLine("Iveskite pirmo studento varda:");
            //student1.Name = Console.ReadLine();

            //Console.WriteLine("Iveskite pirmo studento pavarde:");
            //student2.Surname = Console.ReadLine();

            //Console.WriteLine(student1.Surname);

        }
    }
}