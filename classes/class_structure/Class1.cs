namespace class_structure
{
    public class Car
    {
        //konstantas

        //laukai - fields(private)

        //konstruktorius

        //savybes - properties (public)
        public string Brand;
        public string Model;
        public int Year;
        public int Mileage;


        //metodai - (public)
        public decimal CalculateKilometersPerYear()
        {
            int yearsOld = 2023 - Year;

            return(decimal) Mileage / yearsOld;
        }

        //metodai - (private)
    }
}
