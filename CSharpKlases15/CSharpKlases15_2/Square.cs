namespace CSharpKlases15_2
{
    public class Square : Figure
    {
        // Tada sukurkite išvestines klases "Apskritimas" ir "Kvadratas", kurios paveldės "Figūra" klasę ir perrašys "Brėžti" metodą.
        // Šiame metode kiekviena figūra turėtų rodyti pranešimą, kokia yra spalva.

        public Square(string color) : base(color)
        {

        }

        public override string Draw()
        {
            return $"Tai yra kvadratas, jo spalva yra {Color}.";
        }
    }
}
