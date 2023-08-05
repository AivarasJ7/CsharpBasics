using System;

namespace csharp34
{
    public class FileMethods
    {
        // Parašykite programą, kuri suskaičiuoja kiek žodžių yra faile.
        // Patarimai:
        // Pradėkite nuo testų.Metodo, kuris nuskaito iš failo duomenis testuoti nereikia per sudėtinga kol kas.nebent patys surasit kaip :)
        // Vienas metodas nuskaito iš failo ir grąžina sąrašą, eilučių. Kitas metodas turi parametrą, 
        // kuriam paduodamas sąrašas eilučių, o metodas suskaičiuoja kiek žodžių yra faile.

        /// <summary>
        /// 1. Nuskaitome failo turinį ir parsinešame jį kaip List<string>
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
        /// 1. Skaičiuosime kekvieną žodį kol pasibaigs "stream" ir pridėsime žodį prie žodžių kiekio.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int ProcessFileOnReadingAndCountWords(
            string path,
            string word)
        {
            throw new NotImplementedException();
        }
    }
}
