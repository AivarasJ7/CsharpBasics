
namespace csharp28
{
    public class SymbolCounter
    {
        // Užduoties komentaruose(summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        //Pradėkite nuo testo.
        //Sukurkite metodą, kuriam padavus tekstą, šis suskaičiuoja kiek tekste yra simbolių, neskaitant tarpų.

        /// <summary>
        /// 1. Gauname tekstą
        /// 1.1 Jeigu tekstas tuščias arba null grąžiname 0
        /// 2. Skaičiuojame simbolius be tarpų
        /// 2.1. Išimame tarpus iš teksto
        /// 2.2. Suskaičiuojame simbolius tekste
        /// 2.3. Grąžiname simbolių skaičių.
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
