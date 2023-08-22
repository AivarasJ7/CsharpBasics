namespace classes_intro
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.PrintHey(); //metodas kuris priklauso klasei

            Program programObject = new Program();

            // methodas kuris priklauso objektui
            programObject.PrintHello();
        }

        internal static void PrintHey() // static priklauso klasei
        {
            Console.WriteLine("Hello");
        }

        internal void PrintHello() // non static priklauso objektui sukurtam klasei
        {
            Console.WriteLine("Hello");
        }
           

    }
}