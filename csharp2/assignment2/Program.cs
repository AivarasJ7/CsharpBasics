namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite savo amžių: ");

            int age = int.Parse(Console.ReadLine());

            Console.Write($"“Įvestas amžius: {age}”");
        }
    }
}