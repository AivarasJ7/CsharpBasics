namespace CSharpKlases12
{
    public class Product
    {
        // Prekių klasės: Sukurkite pagrindinę Product klasę su savybėmis Name ir Price ir metodu PrintProductInfo(),
        // kuris išveda visą informaciją apie prekę.
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public decimal Price { get; }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Pavadinimas: {Name}, kaina: {Price}");
        }
    }
}