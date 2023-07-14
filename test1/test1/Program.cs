using static System.Formats.Asn1.AsnWriter;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kilometro kaina eurais (pvz. 0.27),

            Console.WriteLine("Iveskite kilometro kaina eurais: ");
            double kmPrice = double.Parse(Console.ReadLine());

            //minutės kaina eurais(pvz. 0.15),

            Console.WriteLine("Iveskite minutes kaina (eurais):");
            double minutePrice = double.Parse(Console.ReadLine());

            //nuvažiuotas atstumas kilometrais (pvz. 13.6),

            Console.WriteLine("Iveskite nuvažiuota atstuma (kilometrais):");
            double distanceTravelled = double.Parse(Console.ReadLine());

            //sugaištas laikas minutėmis (pvz. 45),

            Console.WriteLine("Iveskite sugaista laika (minutemis):");
            double timeTraveled = double.Parse(Console.ReadLine());

            //įsėdimo mokestis eurais(pvz. 2).

            Console.WriteLine("Iveskite isedimo mokesti (eurais):");
            double passengerFee = double.Parse(Console.ReadLine());

            //Vieno kilometro kainą galite rasti suskaičiavę nuvažiuotą atstumą padauginus iš kilometrų kainos, 
            //plius sugaištą laiką minutėmis padauginus iš minutės kainos, plius įsėdimo mokestis ir viską padalinus iš nuvažiuotų kilometrų.

            double costPerKm = ((distanceTravelled * kmPrice) + (timeTraveled * minutePrice) + passengerFee) / distance * 100;

            //            [ ,] -imtinai
            //            ( , ) - ne imtinai

            if (costPerKm >= 0 && costPerKm <= 22)
            {
                Console.WriteLine("Jūs pigiai pasivažinėjote.");
            }
            else if (costPerKm >= 23 && costPerKm <= 50)
            {
                Console.WriteLine("Šiek tiek daugoka.");
            }
            else if (costPerKm >= 51 && costPerKm <= 100) 
            {
                Console.WriteLine("Daug sumokėjote.");
            }
            else if (costPerKm > 100)
            {
                Console.WriteLine("Geriau rinkitės taksi.");
            }

            //jeigu kaina yra[0, 22] centų, tuomet išspausdinamas pranešimas: "Jūs pigiai pasivažinėjote".
            //Jeigu kaina yra(22, 50] centų, tuomet išspausdinamas pranešimas: "Šiek tiek daugoka".
            //Jeigu kaina yra(50, 100] centų, tuomet išspausdinamas pranešimas: "Daug sumokėjote".
            //Jeigu kaina yra daugiau neigu 100 centų, tuomet išspausdinamas pranešimas: "Geriau rinkitės taksi".
        }
    }
}