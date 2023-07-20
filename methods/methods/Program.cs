namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(2, 3); // metodo iskvietimas
            Console.WriteLine(sum);
            PrintSum(sum);
            PrintSum(Add(5, 10)); // metodas metode

            AddAndPrint(10, 18);

            // metodo kvietimas is kitos klases

            Console.WriteLine(Calculator.Add(50, 100));

            // metodo kvietimas su out parametrais
            Calculator.Divide(
                35, 
                10, 
                out int quotient, // galima kaip nori vadint // out _ discard
                out int remainder); // galima kaip nori vadint

            Console.WriteLine($"Skaiciaus 35 koeficientas yra {quotient}");
            Console.WriteLine($"Liekana: {remainder}");

            // raskite dvizenklio skaiciaus skaitmenu suma
            int number = 91;

            Calculator.Divide(
                number,
                10,
                out int quotient1,
                out int remainder1
                );

            Console.WriteLine($"Dvizenklio skaiciaus {number} suma" +
                $" yra {quotient1 + remainder1}");

            // kvieciame su ref metoda
            string surname = "Jonaitis";

            Console.WriteLine($"Pavarde pries pakeitima: {surname}");

            ChangeSurname(ref surname);

            Console.WriteLine($"Pavarde po pakeitimo: {surname}");


        }

        private static int Add(int number1,int number2) 
        {
            return number1 + number2;
        }

        private static void PrintSum(int result)
        {
            Console.WriteLine($"Gauta suma yra: {result}");
        }

        private static void AddAndPrint(int number1, int number2) // 2 metodai vienam
        {
            int sum = Add(number1, number2);
            PrintSum(sum);
            //PrintSum(Add(number1, number2)); mandresnis
        }

        private static void ChangeSurname(ref string surname)
        {
            Console.WriteLine("Iveskite pakeitima pavardei:");
            surname = Console.ReadLine();
        }
    }
}