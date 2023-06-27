namespace Write_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // Isspausdina ir nukelia i kita eilute
            Console.Write("Hello, World!"); // tik isspausdina
            Console.WriteLine("Kita eilute"); // Isspausdina ir nukelia i kita eilute

            Console.Write("a");
            Console.Write("a");
            Console.Write("a");
            Console.Write("a\n"); // viduj string parasius \n stringas nukeliamas i kita eilute

            Console.WriteLine("d");
            Console.WriteLine("d");
            Console.WriteLine("d");
            Console.WriteLine("d");

            // nuskaitymas is klaviaturos 

            Console.Write("Iveskite varda: ");
            string name = Console.ReadLine();
            Console.Write("Iveskite amziu: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Sveiki mano vardas yra {name} ir man yra {age} metu");
           
           

        }
    }
}