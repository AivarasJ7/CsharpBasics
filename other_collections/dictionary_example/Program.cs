namespace dictionary_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentsDictionary = new Dictionary<int, string>()
            {
                {1, "Jonas"},
                {2, "Petras"},
                {3, "Algis"}
            };

            Console.WriteLine($"Studentas pagal rakta: {studentsDictionary[2]}");

            if (studentsDictionary.TryGetValue(1, out string outedValue))
            {
                Console.WriteLine($"Radau studenta: {outedValue}");
            }

            foreach (int key in studentsDictionary.Keys)
            {
                Console.WriteLine($"Studentas pagal rakta: {key} - {studentsDictionary[key]}");
            }

            // papildity zodyna
            studentsDictionary.Add(4, "Ona");

            //bandymas prideti ir informavimas kad nepavyko

            if (!studentsDictionary.TryAdd(4, "Ona"))
            {
                Console.WriteLine("Deja toks raktas jau yra zodyne");
            }

            //pasalina elementa ir grazina bool reiksme true - pasalina, false- nepasalina
            if (studentsDictionary.Remove(4))
            {
                Console.WriteLine("pavyko istrinti");
            }
            else
            {
                Console.WriteLine("nepavyko istrinti");
            }

            if (studentsDictionary.ContainsKey(2)) 
            {
                Console.WriteLine($"Visdar nepasalintas {studentsDictionary[2]}");
            }
        }
    }
}