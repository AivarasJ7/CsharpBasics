using static System.Net.Mime.MediaTypeNames;

namespace csharp32
{
    public class ArrayMethod
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris sukeičia masyvo elementus vietomis naudodamas "ref" parametrus.

        /// <summary>
        /// 1. Pasikreipsime i metoda
        /// 1.1 Apkeisime pirma ir antra elementa vietomis
        /// 1.2 Grazinsime elementus jau sukeistus vietomis
        /// </summary>
        /// <param name="element1"></param>
        /// <param name="element2"></param>
        public static void SwapElements(ref int element1, ref int element2)
        {
            int temporary = element1; // issisaugom element1 value
            element1 = element2; // "permetam" element2 value i element1
            element2 = temporary; // atsiemam "element1" issaugota anksciau value ir priskiriam element2
        }
    }
}
