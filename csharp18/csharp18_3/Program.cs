namespace csharp18_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Duotas dvimatis masyvas su prekėmis. 
            // Pirmoje eilutėje saugomos daržovių pavadinimai, 
            // antroje eilutėje saugomomi vaisių pavadinimai, 
            // trečioje eilutėje saugomi prieskonių pavadinimai,
            // ketvirtoje - mėsos gaminių pavadinimai, 
            // penktoje - pieno produktų pavadinimai.
            // Sukurkite programą, kuri nuskaito dvimatį masyvą, suranda daržoves ir vaisius kurie prasideda b raide ir sudeda juos į sąrašą.

            string[,] groceries = new string[,]
            {
                { "Potato", "Carrot", "Broccoli", "Garlic"},
                {"Banana", "Watermelon", "Mango", "Kiwi"},
                {"Basil", "Pepper", "Paprika", "Cinnamon"},
                {"Steak", "Chicken", "Ham", "Capocollo"},
                {"Milk", "Cheese", "Curd", "Butter"}
            };

            List<string> fruitAndVegetablesStartingWithB = new List<string>();

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < groceries.GetLength(1); col++)
                {
                    if (groceries[row, col].ToLower().StartsWith('b'))
                    {
                        fruitAndVegetablesStartingWithB.Add(groceries[row, col]);
                    }
                }
            }

            foreach (string word in fruitAndVegetablesStartingWithB)
            {
                Console.WriteLine(word);
            }
        }
    }
}