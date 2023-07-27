using System;

namespace csharp29
{
    public class Factorial
    {
        // Užduoties komentaruose(summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris skaičiuoja ir grąžina faktorialą.

        /// <summary>
        /// 1. Gauname teigiama skaiciu
        /// 2. Jeigu skaicius yra 0 arba 1, gausime rezultata 1
        /// 3. Jeigu skaicius atitinka salyga (teigiamas > 1) tada dauginsime ta skaiciu su tais kurie ejo pries ji pvz:
        /// 5! = 5 * 4 * 3 * 2 * 1 = 120
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Calculate(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            int factorialResult = 1;

            for (int i = 2; i <= number; i++)
            {
                factorialResult *= i;
            }

            return factorialResult;
        }
    }
}