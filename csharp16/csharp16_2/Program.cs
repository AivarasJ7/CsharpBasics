namespace csharp16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Parašykite programą, kuri leidžia vartotojui įvesti n sveikųjų skaičių į List<int> sąrašą, 
            // o tada randa ir atspausdina didžiausią ir mažiausią skaičių.

            List<int> numbers = new List<int>();

            Console.WriteLine("Iveskite elementu skaiciu: ");
            int chosenListSize = int.Parse(Console.ReadLine());

            for (int i = 0; i < chosenListSize; i++)
            {
                Console.Write($"Iveskite skaiciu #{i + 1}: ");
                int number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine($"Didziausias skaicius: {numbers.Max()}");
                Console.WriteLine($"Maziausias skaicius: {numbers.Min()}");
            }

            else
            {
                Console.WriteLine("Neteisingai pasirinktas elementu skaicius.");
            }
        }
    }
}