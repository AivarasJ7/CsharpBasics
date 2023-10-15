namespace CSharpKlases16_2
{
    public class Geometry
    {
        // Užduotis: Sukurkite klasę "Geometrija", kurioje būtų metodai perimetrui apskaičiuoti, vienodais pavadinimais,
        // kuris priimtų skirtingų tipų argumentus (dviejų skirtingų figūrų, kvadrato ir trikampio, perimetrų skaičiavimui).
        // Šitą sprendėm, galite nebent testus parašyti.

        /// <summary>
        /// Calculates perimeter of a square
        /// </summary>
        /// <param name="sideA"></param>
        /// <returns>perimeter of a square</returns>
        public decimal GetPerimeter(decimal sideA)
        {
            return 4 * sideA;
        }

        /// <summary>
        /// Calculates perimeter of a triangle
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns>Perimeter of a triangle</returns>
        public decimal GetPerimeter(decimal sideA, decimal sideB, decimal sideC)
        {
            return sideA + sideB + sideC;
        }

        /// <summary>
        /// Calculates perimater of a rectangle
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <returns>perimeter of a rectanle</returns>
        public decimal GetPerimeter(decimal sideA, decimal sideB)
        {
            return (sideA + sideB) * 2;
        }

        // method overloading (googlej) sis budas vadinasi
    }
}
