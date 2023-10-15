namespace CSharpKlases16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis: Sukurkite klasę "Geometrija", kurioje būtų metodai perimetrui apskaičiuoti, vienodais pavadinimais,
            // kuris priimtų skirtingų tipų argumentus (dviejų skirtingų figūrų, kvadrato ir trikampio, perimetrų skaičiavimui).
            // Šitą sprendėm, galite nebent testus parašyti.

            Geometry geometry = new();

            Console.WriteLine(geometry.GetPerimeter(5));
            Console.WriteLine(geometry.GetPerimeter(5, 10));
            Console.WriteLine(geometry.GetPerimeter(5, 10, 7));
        }
    }
}