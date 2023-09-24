namespace CSharpKlases12
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Prekių klasės: Sukurkite pagrindinę Product klasę su savybėmis Name ir Price ir metodu PrintProductInfo(), kuris išveda visą informaciją apie prekę.
            //Tada sukurkite paveldėtą GroceryItem klasę su papildoma savybe ExpirationDate ir papildomu metodu PrintGroceryItemInfo(),
            //kuris išveda informaciją apie maisto prekę. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

            // Sukurkite paprastą programą, kurioje vartotojas galėtų įvesti duomenis ir, pagal situaciją, būtų sukurta viena ar kita klasė,
            // o duomenų suvedimo metu būtų pildomas bazinės klasės sąrašas.
            // Baigus įvedinėti programa išspausdina visų objektų informaciją.

            Console.WriteLine("Sveiki!");

            List<Product> products = new List<Product>();

            while (true)
            {
                Console.WriteLine("Pasirinkite ka darysite: ");
                Console.WriteLine("1 - Prideti nauja preke");
                Console.WriteLine("2 - Prideti nauja maisto preke");
                Console.WriteLine("3 - Baigti");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Product product = GetProduct();
                        products.Add(product);
                        break;
                    case "2":
                        GroceryItem groceryItem = GetGroceryItem();
                        products.Add(groceryItem);
                        break;
                }

                if (userChoice == "3")
                {
                    break;
                }
            }

            PrintProducts(products);
        }

        private static Product GetProduct()
        {
            Console.WriteLine("Iveskite prekes pavadinima: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite prekes kaina: ");
            decimal price = decimal.Parse(Console.ReadLine());

            return new Product(name, price);
        }

        private static GroceryItem GetGroceryItem()
        {
            Console.WriteLine("Iveskite maisto prekes pavadinima: ");
            string name = Console.ReadLine();

            Console.WriteLine("Iveskite maisto prekes kaina: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite maisto prekes galiojimo pabaigos data: ");
            string expirationDate = Console.ReadLine();

            return new GroceryItem(name, price, expirationDate);
        }

        private static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product is GroceryItem)
                {
                    GroceryItem groceryItem = (GroceryItem)product;
                    groceryItem.PrintGroceryItemInfo();
                }
                else
                {
                    product.PrintProductInfo();
                }
            }
        }
    }
}