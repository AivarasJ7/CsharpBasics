namespace csharp26_1
{
    public class PrimeGenerator
    {
        public static void Main(string[] args)
        {
            // Užduotis 1: Rasti pirmuosius n pirminių skaičių
            // Metodas: Sukurkite metodą, kuris generuoja n pirminių skaičių sąrašą.Parašykite testą.

            int primeNumberCount = 10;
            List<int> primeNumbers = GeneratePrimes(primeNumberCount);

            string output = string.Empty;
         

            Console.WriteLine("Pirminiai skaiciai:");
            foreach (int number in primeNumbers)
            {
                Console.Write($"{number}, ");
            }
        }

        public static List<int> GeneratePrimes(int primeNumberCount)
        {
            List<int> primes = new List<int>();
            int nextNumber = 2;

            while (primes.Count < primeNumberCount)
            {
                if (IsPrime(nextNumber))
                {
                    primes.Add(nextNumber);
                }
                nextNumber++;
            }

            return primes;
        }

        public static bool IsPrime(int number)
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