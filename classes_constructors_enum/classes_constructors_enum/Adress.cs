namespace classes_constructors_enum
{
    public class Adress
    {
        // ctrl . padaro
        
        public Adress(
            string street, 
            int flatNumber, 
            int houseNumber, 
            string city, 
            string country)
        {
            Street = street;
            FlatNumber = flatNumber;
            HouseNumber = houseNumber;
            City = city;
            Country = country;
        }

        public string Street { get; }
        public int FlatNumber { get; }
        public int HouseNumber { get; }
        public string City { get; }
        public string Country { get; }

        //public string GetInfo()
        //{
        //    return $"{Street} {HouseNumber}-{FlatNumber}, {City} {Country}";
        //}

        public override string ToString()
        {
            return $"{Street} {HouseNumber}-{FlatNumber}, {City} {Country}";
        }
    }
}
