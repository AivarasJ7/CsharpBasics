namespace string_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string operations
            string description = "Mano vardas: ";
            string name = "Jonas";

            //1st way to combine strings

            string fullDescription = description + name;

            //2nd way to combine strings
            string fullDescription2 = string.Format("Mano vardas: {0}", name);
            string name2 = "Petras";
            string name3 = "Onute";

            string fullDescription3 = string.Format(
                "Mano klaseje yra {0}, {1}, {2}",
                name,
                name2,
                name3
            );

            //3rd way to combine strings using string interpolation
            string fullDescription4 = $"Mano klaseje yra {name}, {name2}, {name3}";

        }
    }
}