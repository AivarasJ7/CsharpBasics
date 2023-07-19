namespace csharp22_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. užduotis - Knygų katalogas
            // Sukurti knygų katalogą, kuriame saugomas knygos ISBN kodas ir knygos pavadinimas.
            // Pateikti galimybes pridėti, pašalinti ir ieškoti knygų pagal ISBN kodą.

            Dictionary<int, string> bookCatalogue = new Dictionary<int, string>();

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("1 - Prideti knyga");
                Console.WriteLine("2 - Pasalinti knyga");
                Console.WriteLine("3 - Ieskoti knygos pagal ISBN koda");
                Console.WriteLine("0 - Baigti programa");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Iveskite knygos ISBN koda:");
                        int isbn = int.Parse(Console.ReadLine());

                        if (bookCatalogue.ContainsKey(isbn))
                        {
                            Console.WriteLine("Knyga su siuo ISBN jau egzistuoja.");
                        }
                        else
                        {
                            Console.WriteLine("Iveskite knygos pavadinima:");
                            string bookName = Console.ReadLine();

                            bookCatalogue.Add(isbn, bookName);
                            Console.WriteLine("Knyga prideta sekmingai.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Iveskite knygos ISBN koda:");
                        int isbnToRemove = int.Parse(Console.ReadLine());

                        if (bookCatalogue.ContainsKey(isbnToRemove))
                        {
                            bookCatalogue.Remove(isbnToRemove);
                            Console.WriteLine("Knyga pasalinta sekmingai.");
                        }
                        else
                        {
                            Console.WriteLine("Knyga su siuo ISBN kodu nerasta.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Iveskite knygos ISBN koda:");
                        int isbnToFind = int.Parse(Console.ReadLine());

                        if (bookCatalogue.ContainsKey(isbnToFind))
                        {
                            string bookName = bookCatalogue[isbnToFind];
                            Console.WriteLine($"Knyga: {bookName}");
                        }
                        else
                        {
                            Console.WriteLine("Knyga su siuo ISBN kodu nerasta.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Programa baigta.");
                        return;
                }
            }
        }
    }
}