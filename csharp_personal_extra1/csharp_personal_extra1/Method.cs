namespace csharp_personal_extra1
{
    public class Method
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.

        // Sukurkite metodą, kuriam pateikus sveikųjų skaičių masyvą({ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15}) 
        // grąžintu string masyvą {"1", "2", "Fizz", "4", "Buzz"...}.

        // Jei skaičius dalijasi iš 3, grąžintame masyve vietoje jo turi būti "Fizz";
        // Jei skaičius dalijas iš 5, grąžintame masyve vietoje jo turi būti "Buzz";
        // Jei skaičius dalijasi ir iš 3 ir 5, grąžintame masyve vietoje jo turi būti "FizzBuzz";

        /// <summary>
        /// 1 Gausime masyva
        /// 2 Jeigu masyvas yra "null" grazinsime tuscia masyva
        /// 3.1 Jei skaičius dalijasi ir iš 3 ir 5, masyve vietoje to skaičiaus gražinsime "FizzBuzz"
        /// 3.2 Jei skaičius dalijas iš 5, masyve vietoje to skaičiaus gražinsime "Buzz"
        /// 3.3 Jei skaičius dalijasi iš 3, masyve vietoje to skaičiaus gražinsime "Fizz"
        /// </summary>
        /// <param name="fizzBuzz"></param>
        /// <returns></returns>
        public static string[] GetFizzBuzz(int[] array)
        {
            if (array is null)
            {
                return new string[0];
            }

            static string FizzBuzz(int number)
            {
                if (number % 15 == 0)
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0)
                {
                    return "Fizz";
                }
                   
                else if (number % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return number.ToString();
                }
            }

            string[] resultArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i] = FizzBuzz(array[i]);
            }

            return resultArray;
        }
    }
}
