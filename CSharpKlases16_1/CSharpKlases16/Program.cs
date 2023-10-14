using CSharpKlases16_1;

namespace CSharpKlases16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis: Sukurti klasę "Geometrija", kurioje būtų sukurtas abstraktus metodas plotui apskaičiuoti.
            // Tada sukurti klasę "Apskritimas" ir "Kvadratas", kurios paveldėtų "Geometrija" klasę ir perrašytų metodą plotui apskaičiuoti.

            Circle circle = new Circle(4.5);
            Square square = new Square(3.5);

            Console.WriteLine("Apskritimo plotas: " + circle.GetArea());
            Console.WriteLine("Kvadrato plotas: " + square.GetArea());

            Geometry geometry = new();

            Console.WriteLine(geometry.GetPerimeter(5));
            Console.WriteLine(geometry.GetPerimeter(5, 10));
            Console.WriteLine(geometry.GetPerimeter(5, 10, 7));
        }
    }
}