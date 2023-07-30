using static System.Net.Mime.MediaTypeNames;

namespace csharp32
{
    public class ArrayMethod
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris sukeičia masyvo elementus vietomis naudodamas "ref" parametrus.

        /// <summary>
        /// 1.0 Apkeisime pirma ir antra elementa vietomis
        /// 1.2 Grazinsime elementus jau sukeistus vietomis
        /// </summary>
        /// <param name="element1"></param>
        /// <param name="element2"></param>
        public static int[] SwapElementsInArray(int[] array, int element1, int element2)
        {
            if (array is null)
            {
                return new int[0]; 
            }

            int temp = array[element1];
            array[element1] = array[element2];
            array[element2] = temp;

            return new int[] { array[element1], array[element2] };
        }
    }
}
