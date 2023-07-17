namespace hashset_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hashsetas saugo tik unikalias reiksmes

            HashSet<int> uniqueIds = new HashSet<int>();

            uniqueIds.Add(1);
            uniqueIds.Add(2);
            uniqueIds.Add(3);
            uniqueIds.Add(1); // jei pridesime jau esancia reiksme klaidos nebus. parprasciau neprides jos i hashseta

            foreach (int id in uniqueIds)
            {
                Console.WriteLine($"Id: {id}");
            }

            Console.WriteLine($"Elementu hashset rinkynyje yra: {uniqueIds.Count}"); // be .Count() butinai

            uniqueIds.Remove(2);

            Console.WriteLine("Hashset pasalinus elementa:");

            foreach  (int id  in uniqueIds)
            {
                Console.WriteLine($"Id: {id}");
            }

            bool hasNumber2 = uniqueIds.Contains(2);

            Console.WriteLine($"ar rinkinys turi skaiciu 2? atsakymas {hasNumber2}");

            bool hasNumber3 = uniqueIds.Contains(3);

            Console.WriteLine($"ar rinkinys turi skaiciu 3? atsakymas {hasNumber3}");

            uniqueIds.Clear();
            Console.WriteLine("Rinkinys po isvalymo:");

            foreach (int id in uniqueIds)
            {
                Console.WriteLine($"id: {id}");
            }

            List<int> idsList = uniqueIds.ToList();
        } 
    }
}