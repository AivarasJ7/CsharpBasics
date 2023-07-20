using System.Collections.Generic;

namespace csharp22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. užduotis
            // Sukurti žodynėlį, kuriame saugomi prekės kodai ir jų kainos.
            // Leisti vartotojui pridėti naujas prekes, atnaujinti esamų prekių kainas ir ieškoti prekių pagal prekės kodą.

            Dictionary<int, decimal> storeGoods = new Dictionary<int, decimal>();

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("1 - Prideti nauja preke");
                Console.WriteLine("2 - Atnaujinti esamos prekes kaina");
                Console.WriteLine("3 - Ieskoti prekes pagal koda");
                Console.WriteLine("0 - Baigti");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Iveskite prekes koda:");
                        int barCode = int.Parse(Console.ReadLine());

                        if (storeGoods.ContainsKey(barCode))
                        {
                            Console.WriteLine("Si preke jau egzistuoja.");
                        }
                        else
                        {
                            Console.WriteLine("Iveskite prekes kaina:");
                            decimal price = decimal.Parse(Console.ReadLine());

                            storeGoods.Add(barCode, price);
                            Console.WriteLine("Preke prideta sekmingai.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Iveskite prekes koda:");
                        int updateBarCode = int.Parse(Console.ReadLine());

                        if (storeGoods.ContainsKey(updateBarCode))
                        {
                            Console.WriteLine("Iveskite nauja prekes kaina:");
                            decimal newPrice = decimal.Parse(Console.ReadLine());

                            storeGoods[updateBarCode] = newPrice;
                            Console.WriteLine("Prekes kaina atnaujinta sekmingai.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Iveskite prekes koda:");
                        int findBarCode = int.Parse(Console.ReadLine());

                        if (storeGoods.ContainsKey(findBarCode))
                        {
                            decimal price = storeGoods[findBarCode];
                            Console.WriteLine($"Prekes kaina: {price}");
                        }
                        else
                        {
                            Console.WriteLine("Preke su siuo kodu nerasta.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Programa baigta.");
                        return;
                }
            }
        }
    }
}