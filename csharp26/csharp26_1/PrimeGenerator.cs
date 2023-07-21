namespace csharp26_1
{
    public class PrimeGenerator
    {
        public static void Main(string[] args)
        {
            // Užduotis 1: Rasti pirmuosius n pirminių skaičių
            // Metodas: Sukurkite metodą, kuris generuoja n pirminių skaičių sąrašą.Parašykite testą.

            int n = 10;
            List<int> primeNumbers = GeneratePrimes(n);

            Console.WriteLine("Pirminiai skaiciai:");
            foreach (int number in primeNumbers)
            {
                Console.Write($"{number}, ");
            }
        }

        public static List<int> GeneratePrimes(int n)
        {
            List<int> primes = new List<int>();
            int numberToCheck = 2;

            while (primes.Count < n)
            {
                if (IsPrime(numberToCheck))
                {
                    primes.Add(numberToCheck);
                }
                numberToCheck++;
            }

            return primes;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}