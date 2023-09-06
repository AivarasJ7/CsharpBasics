namespace csharpextra1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            // Patikrinkite, ar šis skaičius yra pirminis. Jei skaičius yra pirminis, išveskite: "Skaičius {skaičius} yra pirminis."
            // Jei ne: "Skaičius {skaičius} nėra pirminis."

            Console.Write("Iveskite bet koki sveikaji skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"Skaicius {number} yra pirminis.");
            }
            else
            {
                Console.WriteLine($"Skaicius {number} nėra pirminis.");
            }

            static bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}