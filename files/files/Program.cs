namespace files
{
    public class Program
    {
        static void Main(string[] args)
        {
            string logFilePathName = $"log-{DateTime.Now.ToString("yyMMdd")}.txt";
            string dateTimeToStringFormat = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}";

            AppendLineToFile($"{dateTimeToStringFormat} - programos pradzia", 
                $"log-{logFilePathName}");
            
            WriteSimpleTextToFile("Hello world", "data.txt");
            //BadExample("blogas pavizdys", "data1.txt");
            //BadExample("blogas pavizdys", "data1.txt");

            List<string> lines = new List<string>()
            {
                "Pirma eilute",
                "Antra eilute",
                "Trecia eilute"
            };

            AppendLineToFile($"{dateTimeToStringFormat} - sukurem lista",
               $"log-{logFilePathName}");

            WriteListOfTextToFile(lines, "textLines.txt");

            AppendLineToFile($"{dateTimeToStringFormat} - Iskvietem writeListOfTextToFile",
               $"log-{logFilePathName}");

            AppendLineToFile("sveiki", "append.txt");

            AppendLineToFile($"{dateTimeToStringFormat} - programos pabaiga",
                $"log-{logFilePathName}");
        }

        private static void WriteSimpleTextToFile(
            string text, 
            string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }
        }

        private static void WriteListOfTextToFile(
            List<string> lines, 
            string path)
        {
            using StreamWriter sw = new StreamWriter(path);

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
        }

        private static void AppendLineToFile(
            string text, 
            string path)
        {
            using StreamWriter sw = new StreamWriter(path, true); // true papildo // false viska pakeicia

            sw.WriteLine(text);
        }

        //private static void BadExample(
        //    string text, 
        //    string path)
        //{
        //    StreamWriter sw = File.CreateText(path);

        //    sw.WriteLine(text);

        //    // sw.Close();
        //}
    }
}