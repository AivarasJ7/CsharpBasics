namespace stack_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();

            books.Push("Mokynio zinynas");
            books.Push("C# pradedantiems");
            books.Push("Java programavimas");

            Console.WriteLine($"Knygu kiekis kruvoje: {books.Count}"); //be Count.()

            Console.WriteLine($"Kruvos virsuje yra {books.Peek()}"); // .Peek()

            string element1 = books.Pop(); // paema elementa nuo virsaus ir elementu kiekis sumazeja

            Console.WriteLine($"Paemiau: {element1}");
            Console.WriteLine($"Knygu kiekis kruvoje: {books.Count}");

            string element2 = books.Pop();

            Console.WriteLine($"Paemiau: {element2}");
            Console.WriteLine($"Knygu kiekis kruvoje: {books.Count}");

            // isemimas cikle

            Stack<string> pancakes = new Stack<string>();

            pancakes.Push("blynas1");
            pancakes.Push("blynas2");
            pancakes.Push("blynas3");
            pancakes.Push("blynas4");

            //foreach (string pancake in pancakes)
            //{
            //    Console.WriteLine(pancakes.Pop()); // bloga pavizdys iteracijai, nes viduj foreach passikeicia collectionas
            //}

            //int stackCount = pancakes.Count;
            //for (int i = 0; i < stackCount; i++)      //standartinis variantas
            //{
            //    Console.WriteLine(pancakes.Pop());
            //}

            for (int i = pancakes.Count; i > 0; i--)
            {
                Console.WriteLine(pancakes.Pop());
            }
        }
    }
}