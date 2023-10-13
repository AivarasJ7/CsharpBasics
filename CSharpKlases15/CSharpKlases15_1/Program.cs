using System;

namespace CSharpKlases15_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 1:
            // Sukurkite klasę "Gyvūnas" su protected savybe "vardas".

            // Tada sukurkite klases "Šuo" ir "Katinas", kurios paveldės "Gyvūnas" klasę ir perrašys "Garsas" metodą.
            // Kiekvienoje "Šuo" ir "Katinas" klasėse "Garsas" metodas turėtų naudoti "vardas" savybę

            // Žinoma naudokite angliškus pavadinimus.
            // Užduotys yra tik bazinės idėjos, jas galite išplėtoti, parašydami programą su galimybe skaičiuoti ar registruoti objektus,
            // po to išvedant informaciją į failą ar pan.Tai yra kūrybinės užduotys. Jeigu išeina parašykite testus.

            Dog dog = new Dog("Rembo");
            Cat cat = new Cat("Irisas");

            Console.WriteLine(dog.MakeASound());
            Console.WriteLine(cat.MakeASound());
        }
    }
}