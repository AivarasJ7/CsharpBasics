using System.Xml.Linq;

namespace CSharpKlases15_2
{
    public class Circle : Figure
    {
        // Tada sukurkite išvestines klases "Apskritimas" ir "Kvadratas", kurios paveldės "Figūra" klasę ir perrašys "Brėžti" metodą.
        // Šiame metode kiekviena figūra turėtų rodyti pranešimą, kokia yra spalva.

        public Circle(string color) : base(color)
        {

        }

        public override string Draw()
        {
            return $"Tai yra apskritimas, jo spalva yra {Color}.";
        }
    }
}
