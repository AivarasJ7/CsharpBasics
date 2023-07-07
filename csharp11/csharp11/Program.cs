namespace csharp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paskaitoje naudotą pavyzdį su laptopu ir stacionariu kompiuteriu pritaikykite šiai užduočiai. 
            //Susigalvoti kitą temą, kurioje išeitų panaudoti tris pasirinkimus (pvz.: 1 - šuo, 2 - katė, 3 - žiurkėnas). 
            //Kol vartotojas nesuves tinkamų duomenų tol vykdyti ciklą.

            int choice;

            do
            {
                Console.WriteLine("Pasirinkite gyvuna: 1 - šuo, 2 - katė, 3 - žiurkėnas");
                choice = int.Parse(Console.ReadLine());

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Nera tokio pasirinkimo, bandykite dar karta");
                }

            } while (choice < 1 || choice > 2);

            Console.WriteLine($"Pasirinkimas {choice}");
        }
    }
}