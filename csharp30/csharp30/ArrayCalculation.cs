using static System.Net.Mime.MediaTypeNames;

namespace csharp30
{
    public class ArrayCalculation
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris apskaičiuoja dvimačio masyvo elementų sumą.

        /// <summary>
        /// 1. Gausime 2d Array
        /// 2. Iteruosim per kekviena elementa ir sudesim juos
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int CountTwoDimensionalArraySum(int[,] array)
        {
            if (array is null)
            {
                return 0;
            }

            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            return sum;
        }
    }
}
