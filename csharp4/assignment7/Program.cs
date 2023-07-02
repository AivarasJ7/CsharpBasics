namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7. Parašykite programą, kuri laipsnius paverstų į kelvinus ir fahrenheitus.
                 (0°C × 9/5) + 32 = 32°F
                 0°C + 273.15 = 273.15K
             */

            Console.Write("Įveskite temperatūrą °C:");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = (celsius * 9 / 5) + 32;
            decimal kelvin = celsius + 273.15m;

            Console.WriteLine("Temperatūra °F: " + fahrenheit);
            Console.WriteLine("Temperatūra K: " + kelvin);
        }
    }
}