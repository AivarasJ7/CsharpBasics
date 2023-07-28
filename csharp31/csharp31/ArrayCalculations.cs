namespace csharp31
{
    public class ArrayCalculations
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris randa didžiausią ir mažiausią elementą masyve naudodamas "out" parametrus.

        /// <summary>
        /// 1. Gausime masyva
        /// 2. Rasime Didziausia ir maziausia elementa masyve 
        /// 3. Grazinsime su out abudu elementus
        /// </summary>
        /// <param name="array"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        public static void FindArrayMaxMin(int[] array, out int max, out int min)
        {
            max = int.MinValue;
            min = int.MaxValue;

            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }

                if (element < min)
                { 
                    min = element; 
                }
            }
        }
    }
}
