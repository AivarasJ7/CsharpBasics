namespace csharp33
{
    public class FileMethods
    {
        // Duotas failas su skaičiais. Raskite:
        // 1. didžiausią skaičių;
        // 2. mažiausią skaičių;
        // 3. vidurkį;
        // 4. išveskite atsitiktinį skaičių iš šio failo.

        // Patarimai:
        // Pradėkite nuo testų.Metodo, kuris nuskaito iš failo duomenis testuoti nereikia per sudėtinga kol kas.nebent patys surasit kaip :)
        // Vienas metodas nuskaito iš failo ir grąžina tekstą.Kitas metodas turi parametrą, kuriam paduodamas tekstas,
        // o metodas apdoroja tuos skaičus.Gali būti daugiau metodų. Stenkitės skaidyti metodus į kuo smulkesnes dalis.Pvz.
        // Metodas failui nuskaityti - grąžina string
        // Metodas konvertuoti tekstą į skaičių sąrašą
        // Metodas kuris skaičių sąraše randa tai ko reikalauja sąlyga.

        /// <summary>
        /// 1. Nuskaitome failo turinį ir parsinešame jį kaip "string"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<string> ReadFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return new List<string>();
            }

            List<string> lines = new List<string>();

            using StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                lines.Add(line);
            }

            return lines;
        }

        /// <summary>
        /// 1.Konvertuosim skaičius iš string sąrašo į int formato sąrašą
        /// 1.1 Iteruosim per kekvieną eilutę ir konvertuosim į "int" ir pasidarysim "int" "list'a" pridedami kekvieną skaičių.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static List<int> ConvertToNumberList(List<string> lines)
        {
            if (lines is null)
            {
                return new List<int>();
            }

            List<int> numbers = new List<int>();

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        /// <summary>
        /// 1. Surasime didžiausią skaičių saraše, kuris yra parneštas iš failo
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int FindMaxNumberFromFile(List<int> numbers)
        {
            return numbers.Max();
        }

        /// <summary>
        /// 1. Surasime mažiausią skaičių saraše, kuris yra parneštas iš failo.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int FindMinNumberFromFile(List<int> numbers)
        {
            return numbers.Min();
        }

        /// <summary>
        /// 1. Surasime skaičių vidurkį saraše, kuris yra parneštas iš failo
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double CalculateAverageFromFile(List<int> numbers)
        {
            return numbers.Average();
        }

        /// <summary>
        /// 1. Parnešime atsitiktinį skaičių iš sarašo, kuris yra parneštas iš failo
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GetRandomNumberFromFile(List<int> numbers)
        {
            Random random = new Random();
            int randomIndex = random.Next(numbers.Count);

            return numbers[randomIndex];
        }
    }
}
