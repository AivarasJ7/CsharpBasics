namespace CSharpKlases7
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Knygų klasės: Sukurkite pagrindinę Book klasę su savybėmis Title, Author ir PublicationYear ir metodu PrintBookInfo(),
            // kuris išveda visą informaciją apie knygą.
            // Tada sukurkite paveldėtą Textbook klasę su papildoma savybe Subject ir papildomu metodu PrintTextbookInfo(), kuris išveda informaciją apie vadovėlį.
            // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            List<Book> books = new List<Book>();

            Console.WriteLine("Sveiki, atvyke!");

            while (true)
            {
                Console.WriteLine("Pasirinkite, ką darysite:");
                Console.WriteLine("1 - Prideti nauja knyga");
                Console.WriteLine("2 - Prideti nauja vadoveli");
                Console.WriteLine("3 - Baigti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book newBook = AddNewBook();
                        books.Add(newBook);
                        break;

                    case 2:
                        Textbook newTextbook = AddNewTextbook();
                        books.Add(newTextbook);
                        break;

                    case 3:
                        DisplayBookInfo(books);
                        return;

                    default:
                        Console.WriteLine("Neteisingas pasirinkimas. Bandykite dar karta.");
                        break;
                }
            }
        }

        private static Book AddNewBook()
        {
            Console.WriteLine("Iveskite knygos pavadinima: ");
            string title = Console.ReadLine();
            Console.WriteLine("Iveskite knygos autoriu: ");
            string author = Console.ReadLine();
            Console.WriteLine("Iveskite knygos isleidimo metus: ");
            int publicationYear = int.Parse(Console.ReadLine());

            return new Book(title, author, publicationYear);
        }

        private static Textbook AddNewTextbook()
        {
            Console.WriteLine("Iveskite vadovelio pavadinima: ");
            string title = Console.ReadLine();
            Console.WriteLine("Iveskite vadovelio autoriu: ");
            string author = Console.ReadLine();
            Console.WriteLine("Iveskite vadovelio isleidimo metus: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite vadovelio tema: ");
            string subject = Console.ReadLine();

            return new Textbook(title, author, publicationYear, subject);
        }

        private static void DisplayBookInfo(List<Book> books)
        {
            Console.WriteLine("Informacija apie knygas ir vadovelius:");
            foreach (Book book in books)
            {
                if (book is Textbook textbook)
                {
                    Console.WriteLine(textbook.PrintTextbookInfo());
                }
                else
                {
                    Console.WriteLine(book.PrintBookInfo());
                }
            }
        }
    }
}
