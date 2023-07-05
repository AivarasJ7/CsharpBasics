namespace csharp7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Liepkite vartotojui įvesti egzamino rezultatą (0-100), su viena sąlyga, per atskiras else if dalis, patikrinti šias ribas:
            //2.1. ar gautas rezultatas yra lygus 100;
            //2.2. ar gautas rezultatas yra lygus arba didesnis nei 80;
            //2.3. ar gautas rezultatas yra lygus arba didesnis nei 50;
            //2.4. ar gautas rezultatas yra lygus arba didesnis nei 20;
            //2.5. ar gautas rezultatas yra mažesnis nei 20;

            Console.WriteLine("Iveskite egzamino rezultata (0-100): ");
            int score = int.Parse(Console.ReadLine());

            if (score == 100)
            {
                Console.WriteLine($"{score} - puikiai!");
            }
            else if (score >= 80 && score < 100)
            {
                Console.WriteLine($"{score} - gerai.");
            }
            else if (score >= 50 && score < 80)
            {
                Console.WriteLine($"{score} - neblogai.");
            }
            else if (score >= 20 && score < 50)
            {
                Console.WriteLine($"{score} - prastai.");
            }
            else if (score >= 0 && score < 20)
            {
                Console.WriteLine($"{score} - labai blogai.");
            }
        }
    }
}