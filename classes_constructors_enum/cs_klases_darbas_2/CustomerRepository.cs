namespace cs_klases_darbas_2
{
    public class CustomerRepository
    {
        //3.Sukurkite klasę duomenims iš failo nuskaityti ir pavadinkite CustomerRepository
        //su vieninteliu metodu List, kuris grąžina teksto eilutes.

        /// <summary>
        /// Reads files with headers, can skip headers
        /// </summary>
        /// <param name="path"></param>
        /// <param name="skipHeader"></param>
        /// <returns></returns>
        public List<string> List(string path, bool skipHeader)
        {
            using StreamReader sr = new StreamReader(path);

            if (skipHeader)
            {
                sr.ReadLine();
            }

            List<string> lines = new List<string>();

            while (!sr.EndOfStream)
            {
                lines.Add(sr.ReadLine());
            }

            return lines;
        }
    }
}
