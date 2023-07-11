namespace pair_programming_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Užduotis: Atrinkti visus neigiamus skaičius iš int tipo masyvo.
            //Aprašymas: Sukurkite int tipo masyvą su neigiamais ir teigiamais skaičiais.
            //Atrinkite visus neigiamus skaičius į naują masyvą ir atspausdinkite juos ekrane.

            int[] numbers = { 1, 2, 3, -4, -5 };

            int negativeNumbersCount = 0;

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbersCount++;
                }
            }

            int[] negativeNumbers = new int[negativeNumbersCount];

            int negativeNumbersIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] < 0 )
                {
                    negativeNumbers[negativeNumbersIndex] = numbers[i];
                    negativeNumbersIndex++;
                }
            }
        }
    }
}