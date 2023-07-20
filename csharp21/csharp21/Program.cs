namespace csharp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sukurkite programą, kuri imituos kavos automato užsakymų eilę. 
            // Automatas aptarnauja užsakymus vieną po kito. Nauji užsakymai pridedami į eilės galą, o aptarnavus užsakymą jį pašaliname iš eilės pradžios. 
            //Naudokite Queue<T> struktūrą. Pradžioje sudedami užsakymai, po to jie aptarnaujami iš eilės.

            Queue<string> ordersQueue = new Queue<string>();

            Console.WriteLine("Iveskite uzsakymus (iveskite 'q' noredami prieiti prie uzsakymu):");

            string input;
            do
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    ordersQueue.Enqueue(input);
                }
            } while (input != "q");

            Console.WriteLine("Aptarnaujami uzsakymai:");
            while (ordersQueue.Count > 0)
            {
                Console.WriteLine($"{ordersQueue.Dequeue()}");
            }

            Console.WriteLine("Visi uzsakymai aptarnauti.");
        }
    }
}