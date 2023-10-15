namespace CSharpKlases16_1
{
    public class Circle : Geometry
    {
        // Tada sukurti klasę "Apskritimas" ir "Kvadratas", kurios paveldėtų "Geometrija" klasę ir perrašytų metodą plotui apskaičiuoti.

        public Circle(double radius)
        {
            this.radius = radius;
        }

        private double radius;

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
