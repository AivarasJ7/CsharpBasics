namespace CSharpKlases16_1
{
    public class Square : Geometry
    {
        // Tada sukurti klasę "Apskritimas" ir "Kvadratas", kurios paveldėtų "Geometrija" klasę ir perrašytų metodą plotui apskaičiuoti.

        public Square(double sideLength)
        {
            sideLength = sideLength;
        }

        private double sideLength;

        public override double GetArea()
        {
            return sideLength * sideLength;
        }
    }
}
