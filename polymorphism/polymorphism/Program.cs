using polymorphism.Dynamic;
using polymorphism.Static;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new();

            Console.WriteLine(geometry.GetPerimeter(5));
            Console.WriteLine(geometry.GetPerimeter(5, 10));
            Console.WriteLine(geometry.GetPerimeter(5, 10, 7));

            Manager manager = new Manager("Jonas", "Puikus darbuotojas");

            Console.WriteLine(manager.GetRoleDescription());
        }
    }
}