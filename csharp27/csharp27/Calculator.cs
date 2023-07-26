namespace csharp27
{
    public class Calculator
    {
        // Užduoties komentaruose (summary), privačiai lektoriui, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuriam padavus sąrašą skaičių, randa visų lyginių skaičių sumą.

        /// <summary>
        /// 1.Tikriname ar sarasas yra "null" arba tuščias, rezultatas yra 0
        /// 2. Apskaiciuojame visu pateikto saraso lyginiu skaiciu suma
        /// 2.1 Susikuriame "lyginiu skaiciu suma = 0" kintamaji kad nuo starto butu 0.
        /// 2.2 tikriname ar skaicius is saraso dalinasi is 2 ir po modalines dalybos yra lygus 0
        /// 2.3 pridedame ta lygini skaiciu kuris dalinasi is 2 i bendra lyginiu skaiciu suma.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>

        public static int EvenNumbersSumFromList(List<int> numbers)
        {
            if (numbers is null || numbers.Count == 0)
            {
                return 0;
            }

            int sumOfEvenNumbers = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNumbers += number;
                }
            }

            return sumOfEvenNumbers;
        }
    }
}
