namespace CSharpKlases12
{
    public class GroceryItem : Product
    {
        // Tada sukurkite paveldėtą GroceryItem klasę su papildoma savybe ExpirationDate ir papildomu metodu PrintGroceryItemInfo(),
        // kuris išveda informaciją apie maisto prekę. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public GroceryItem(string name, decimal price, string expirationDate) : base(name, price)
        {
            ExpirationDate = expirationDate;
        }

        public string ExpirationDate { get; }

        public void PrintGroceryItemInfo()
        {
            Console.WriteLine($"Pavadinimas: {Name}, kaina: {Price}, galiojimo pabaigos data: {ExpirationDate}");
        }
    }
}