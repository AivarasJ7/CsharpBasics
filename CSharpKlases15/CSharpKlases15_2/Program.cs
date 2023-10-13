namespace CSharpKlases15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 2:
            // Sukurkite bazinę klasę "Figūra" su protected savybe "spalva".

            // Tada sukurkite išvestines klases "Apskritimas" ir "Kvadratas", kurios paveldės "Figūra" klasę ir perrašys "Brėžti" metodą.
            // Šiame metode kiekviena figūra turėtų rodyti pranešimą, kokia yra spalva.

            // Žinoma naudokite angliškus pavadinimus.
            // Užduotys yra tik bazinės idėjos, jas galite išplėtoti, parašydami programą su galimybe skaičiuoti ar registruoti objektus,
            // po to išvedant informaciją į failą ar pan.Tai yra kūrybinės užduotys. Jeigu išeina parašykite testus.

            Circle circle = new Circle("Zalia");
            Square square = new Square("Raudona");

            Console.WriteLine(circle.Draw());
            Console.WriteLine(square.Draw());
        }
    }
}