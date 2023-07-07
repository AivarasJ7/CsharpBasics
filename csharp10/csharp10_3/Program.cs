namespace csharp10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Padarykite skaičiuotuvą.Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            //Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. Pvz.:
            //5 + 4 = 9
            //5 - 4 = 1
            //…
            //Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

            bool runCalculator = true;

            while (runCalculator)
            {
                Console.WriteLine("Įveskite pirmąjį skaičių:");
                double number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Įveskite antrąjį skaičių:");
                double number2 = double.Parse(Console.ReadLine());

                double sum = number1 + number2;
                double difference = number1 - number2;
                double multiply = number1 * number2;

                if (number2 != 0)
                {

                    double divide = number1 / number2;
                    Console.WriteLine($"{number1} + {number2} = {sum}");
                    Console.WriteLine($"{number1} - {number2} = {difference}");
                    Console.WriteLine($"{number1} * {number2} = {multiply}");
                    Console.WriteLine($"{number1} / {number2} = {divide}");
                }
                else
                {
                    Console.WriteLine($"{number1} + {number2} = {sum}");
                    Console.WriteLine($"{number1} - {number2} = {difference}");
                    Console.WriteLine($"{number1} * {number2} = {multiply}");
                    Console.WriteLine("Dalyba iš 0 negalima.");
                }

                Console.WriteLine("Ar norite atlikti dar vieną skaičiavimą? (taip / ne)");
                string input = Console.ReadLine();

                if (input.ToLower() != "taip")
                    runCalculator = false;

                Console.WriteLine();
            }

            Console.WriteLine("Programa baigė darbą. Viso gero!");
        }
    }
}