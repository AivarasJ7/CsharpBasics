using System;
using System.Collections.Generic;

namespace csharp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> parkingLot = new Stack<string>();

            int maxCapacity = 6;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("1 - Ivaziavimas");
                Console.WriteLine("2 - Isvaziavimas");
                Console.WriteLine("3 - Perziureti paskutini i aikstele ivaziavusi automobili");
                Console.WriteLine("4 - Pabaigti programa");

                string option = Console.ReadLine();
                Console.WriteLine();

                if (option == "1")
                {
                    if (parkingLot.Count >= maxCapacity)
                    {
                        Console.WriteLine("Aikstele pilna. Negalima prideti naujo automobilio.");
                    }
                    else
                    {
                        Console.WriteLine("Iveskite automobilio valstybini numeri:");

                        string plate = Console.ReadLine();
                        parkingLot.Push(plate);

                        Console.WriteLine("Automobilis pastatytas i aikstele");
                    }
                }
                else if (option == "2")
                {
                    if (parkingLot.Count == 0)
                    {
                        Console.WriteLine("Veiksmas nepavyko. Automobiliu aikstele tuscia.");
                    }
                    else
                    {
                        Console.WriteLine($"Automobilis {parkingLot.Pop()} isvaziavo is aiksteles");
                    }
                }
                else if (option == "3")
                {
                    if (parkingLot.Count == 0)
                    {
                        Console.WriteLine("Automobiliu aikstele tuscia.");
                    }
                    else
                    {
                        Console.WriteLine($"Paskutinio automobilio, ivaziavusio i aikstele, numeris: {parkingLot.Peek()}");
                    }
                }
                else if (option == "4")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Netinkamas pasirinkimas. Bandykite dar karta.");
                }

                Console.WriteLine();
            }
        }
    }
}
