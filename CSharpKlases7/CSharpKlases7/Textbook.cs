namespace CSharpKlases7
{
    // Tada sukurkite paveldėtą Textbook klasę su papildoma savybe Subject ir papildomu metodu PrintTextbookInfo(), kuris išveda informaciją apie vadovėlį.
    // Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.
    public class Textbook : Book
    {
        public Textbook(string title, string author, int publicationYear, string subject) : base(title, author, publicationYear)
        {
            Subject = subject;
        }

        public string Subject { get; }

        public string PrintTextbookInfo()
        {
            return $"Vadovelio pavadinimas yra {Title}, jos autorius yra {Author} ir ji buvo pagaminta {PublicationYear} metais, jo tema yra {Subject}.";
        }
    }
}
