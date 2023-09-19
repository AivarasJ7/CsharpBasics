using System.Reflection;

namespace CSharpKlases7
{
    public class Book
    {
        // Knygų klasės: Sukurkite pagrindinę Book klasę su savybėmis Title, Author ir PublicationYear ir metodu PrintBookInfo(),
        // kuris išveda visą informaciją apie knygą.
        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }

        public string PrintBookInfo()
        {
            return $"Knygos pavadinimas yra {Title}, jos autorius yra {Author} ir ji buvo pagaminta {PublicationYear} metais.";
        }
    }
}
