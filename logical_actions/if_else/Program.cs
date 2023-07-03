namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // isspausdinti ar skaicius yra lyginis ar nelyginis
            Random random = new Random();
            int number = random.Next(1, 100);
            bool isEvenNumber = number % 2 == 0;

            if (isEvenNumber)
            {
                Console.WriteLine($"Skaicius {number} yra lyginis");
            }
            else
            {
                Console.WriteLine($"Skaicius {number} yra nelyginis");
            }

            string password = "qwerty123";

            if (password == "qwerty123" ||
               password == "zxcvb123" ||
               password == "asdfgh123")
            {
                Console.WriteLine("Valio! Nulauzta");
            }
            else
            {
                Console.WriteLine("Deja, Nepavyko");
            }

            // ar atsitiktinis skaicius yra intervale [5, 50]

            if (number >= 5 && number <= 50)
            {
                Console.WriteLine($"skaicius {number} yra intervale [5, 50]");
            }
            else 
            {
                Console.WriteLine($"skaicius {number} nera intervale [5, 50]");
            }
        }
    }
}