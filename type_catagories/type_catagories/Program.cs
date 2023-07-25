namespace type_catagories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            TryToChangeIntValue(number);
            Console.WriteLine(number);

            string studentName = "Jonas";
            TrytoChangeStringValue(studentName);
            Console.WriteLine(studentName);

            Dictionary<int, string> myShoppingCart = new Dictionary<int, string>()
            {
                { 1, "Duona"},
                { 2, "Suris"},
                { 3, "Pomidor"},
                { 4, "Agurkai"},
            };

            TryToChangeDictionary(myShoppingCart);

            foreach (int key in myShoppingCart.Keys)
            {
                Console.WriteLine($"{key}. {myShoppingCart[key]}");
            }

        }

        // strukturinio tipo (value type) testas/bandymas

        private static void TryToChangeIntValue(int number)
        {
            number = 5;
        }

        //su string
        private static void TrytoChangeStringValue(string name)
        {
            name = "Petras";
        }

        // su dictionary (reference type)
        private static void TryToChangeDictionary(Dictionary<int, string> items)
        {
            items.Add(5, "Pienas");
        }
    }
}