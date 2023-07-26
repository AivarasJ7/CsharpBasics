
namespace csharp28
{
    public class SymbolCounter
    {
        // Užduoties komentaruose(summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        //Pradėkite nuo testo.
        //Sukurkite metodą, kuriam padavus tekstą, šis suskaičiuoja kiek tekste yra simbolių, neskaitant tarpų.

        /// <summary>
        /// 1. Duosime teksta ir suskaiciuosime kiek yra symboliu (neskaitant tarpu)
        /// 2. Paduodame teksta kuris yra null
        /// 2.1 Suskaiciuotu simboliu rezultatas jeigu tekstas buvo paduotas null turi buti 0
        /// 3. Paduodame teksta kuris yra tuscias
        /// 3.1 Suskaiciuotu simboliu rezultatas jeigu tekstas buvo paduotas tuscias turi buti 0
        /// 4 Paduodame teksta su tarpais
        /// 4.2 Isimame tarpus is teksto
        /// 4.3 Skaciuojame simbolius (su jau isimtais tarpais is teksto)
        /// 4.4 Gauname rezultata
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static int CountTextSymbolsWithoutSpaces(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }
            
            string textWithoutSpaces = text.Replace(" ", "");

            int symbolCount = textWithoutSpaces.Length;

            return symbolCount;
        }
    }
}
