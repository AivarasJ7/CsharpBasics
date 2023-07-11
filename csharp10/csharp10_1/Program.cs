namespace csharp10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WHILE ciklo arba do -while naudojimas.
            //1.Liepkite vartotojui įvesti teigiamą skaičių.
            //Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.Pvz.: 5 4 3 2 1.
            //Kiekvieną kartą išvesti skirtingose eilutėse.

            Console.WriteLine("Iveskite teigiama skaiciu: ");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}