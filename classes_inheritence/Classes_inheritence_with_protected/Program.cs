namespace Classes_inheritence_with_protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Jonas", "puikus vadybininkas");

            Console.WriteLine(manager.GetRoleDescription());
        }
    }
}