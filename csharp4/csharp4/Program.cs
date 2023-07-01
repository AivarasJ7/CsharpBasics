namespace csharp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite:
                “Jūsų vardas { vardas},  o amžius { amžius}.” */

            Console.Write("Įveskite savo vardą: ");
            string name = Console.ReadLine();

            string ageInput;
            int age;

            do
            {
                Console.Write("Įveskite savo amžių: ");
                ageInput = Console.ReadLine();

                if (!int.TryParse(ageInput, out age))
                {
                    Console.WriteLine("Neteisingai įvestas amžius. Įveskite iš naujo.");
                }
            } while (!int.TryParse(ageInput, out age));

            Console.WriteLine($"Jūsų vardas {name}, o amžius {age}.");
        }
    }
}