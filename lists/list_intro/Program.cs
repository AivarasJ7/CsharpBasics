using System.IO.Pipes;
using System.Threading.Channels;

namespace list_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializacija
            List<int> numbers1 = new List<int>();
            List<string> names = new List<string>();

            // elementu pridejimas prie List
            numbers1.Add(5);
            numbers1.Add(10);
            numbers1.Add(3);

            names.Add("Jonas");
            names.Add("Petras");
            names.Add("Onute");

            //prieiga prie elementu
            Console.WriteLine($"{numbers1[1]} {names[2]}");

            //inicializacija su duomenimis
            List<string> names2 = new List<string>()
            {
                "Alice",
                "Bob",
                "Charlie"
            };

            names2.Add("John");

            // iteravimas su foreach
            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < names2.Count; i++)
            {
                Console.WriteLine(names2[i]);
            }

            //pasalinti bob pagal reiksme
            names2.Remove("Bob");

            //pasalinti pagal indeksa
            names2.RemoveAt(0);

            // Contains - surasti elementa, grazina bool
            if (names2.Contains("Bob"))
            {
                Console.WriteLine("sveikas bob'ai");
            }
            if (names2.Contains("John")) 
            {
                Console.WriteLine("Sveikas Johnai");
            }

            //gauti elemento indeksa
            int index = names2.IndexOf("John");
            int index2 = names2.IndexOf("Bob");

            if (names2.IndexOf("John") > -1)
            {
                Console.WriteLine("Sveikas Johnai pagal indeksa");
            }

            //galima naudoti metodus Sum, Average, Min, Max,
            //First, Last ir t.t.

            //Surikiavimas, skaicius rikiuoja is eiles
            //zodzius pagal abecele

            names2.Add("Ana");
            names2.Sort(); // indeksai nepasilieka kokie buvo indeksai nevaiksto kartu reikia pries sortinti

            // reverse - apsukti sarasa (po abeceles butu nuo z) indeksai nevaiksto kartu
            names2.Reverse();

            //AddRange - prideti sarasa prie saraso

            List<string> group1 = new List<string>()
            {
                "Ana",
                "Alice",
                "Grace",
            };

            List<string> group2 = new List<string>()
            {
                "Ben",
                "John",
                "Bob"
            };

            List<string> group3 = new List<string>();

            group3.AddRange(group1);
            group3.AddRange(group2);

            group3.Sort();

            group3.ForEach(x => Console.WriteLine(x)); // x = person si kart 
            //x=> x...

            //foreach (string person in group3)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}