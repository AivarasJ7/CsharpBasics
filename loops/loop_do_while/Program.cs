namespace loop_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do while


            //do
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Visada viena karta iteruojama");
            //} while (false);

            // ivedinejimas, kol vartotojas ives teigiama skaiciu
            Console.WriteLine("Iveskite teigiama skaiciu: ");
            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Ivedete neigiama arba 0 " +
                        "bandykite dar karta");
                }
            } while (number <= 0);

            Console.WriteLine($"Jus ivedete teigiama skaiciu {number}");

            // Parašykite programą, kuri leidžia vartotojui pasirinkti            // vieną iš dviejų kompiuterių tipų - nešiojamąjį (laptopą)            // arba stacionarųjį kompiuterį.            // Programa turi prašyti vartotojo įvesti skaičių 1 arba 2,            // kur 1 atitinka nešiojamąjį kompiuterį,            // o 2 - stacionarųjį kompiuterį. Jeigu vartotojas įveda netinkamą            // skaičių, turi būti parodytas klaidos pranešimas,            // o programa turi prašyti vartotojo pakartoti savo pasirinkimą,            // kol bus įvestas tinkamas skaičius. Galiausiai programa turi            // atspausdinti vartotojo pasirinkimą.

            int choice;

            do
            {
                Console.WriteLine("Pasirinkite 1- laptopas 2 - stacionarus:");
                choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                }

            } while (choice < 1 || choice > 2);

            Console.WriteLine($" Pasirinkimas {choice}");
        }
    }
}