namespace pair_programming_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Užduotis: Sukurti decimal tipo masyvą ir apskaičiuoti jo elementų sumą.
            //Aprašymas: Sukurkite decimal tipo masyvą su penkiais elementais.
            //Apskaičiuokite masyvo teigiamų elementų sumą ir atspausdinkite ją ekrane.

            Random random = new Random();
            decimal[] numbers = new decimal[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100);
            }

            decimal result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) 
                {
                    result += numbers[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}