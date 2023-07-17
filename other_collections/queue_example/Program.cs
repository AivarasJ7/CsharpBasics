namespace queue_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> students = new Queue<string>();

            students.Enqueue("Jonas");
            students.Enqueue("Petras");
            students.Enqueue("Algis");
            students.Enqueue("Ona");

            // kas pirmas aptarnaujamas
            Console.WriteLine($"Pirmas aptarnaujamas: {students.Peek()}");

            // Console.WriteLine(students.Dequeue());

            while (students.Count > 0)
            {
                Console.WriteLine($"Aptarnaujamas studentas: {students.Dequeue()}");
            }
        }
    }
}