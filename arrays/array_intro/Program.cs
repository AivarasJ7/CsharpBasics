namespace array_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // truputi senesnis inicijavimas
            int[] grades1 = new int[] { 7, 8, 4, 10 };

            // paprastesnis/ naujesnis inicijavimas
            int[] grades2 = { 10, 7, 4, 8, 4, 4, 10 };

            // isspausdinti 2-a 3-a 4-a elementus
            Console.WriteLine(grades2[1]);
            Console.WriteLine(grades2[2]);
            Console.WriteLine(grades2[3]);

            // vardu masyvas
            string[] names = {"Jonas", "Petras", "Onute" };

            //pirmasis elementas
            Console.WriteLine(names[0]); //.First()

            //paskutinis elementas

            Console.WriteLine(names.Last()); // .Last

            Console.WriteLine(names[names.Length - 1]);

            // pradedame nuo tuscio masyvo
            int[] grades3 = new int[5];

            // priskiriame reiskmes tusciam masyvui
            grades3[0] = 10;
            grades3[1] = 7;
            grades3[2] = 8;
            grades3[3] = 4;
            grades3[4] = 10;

            // su string tipu
            string[] names2 = new string[3];

            for (int i = 0; i < names2.Length; i++)
            {
                Console.WriteLine($"Iveskite {i + 1}-a varda: ");
                names2[i] = Console.ReadLine();
            }

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
        }
    }
}