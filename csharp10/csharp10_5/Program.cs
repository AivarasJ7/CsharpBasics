namespace csharp10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Liepkite vartotojui įvedinėti atsitiktinius skaičius. Šį ciklą vykdyti tol, kol įvestas skaičius nesidalins iš 9. 
            //(pridėtas paveiksliukas 5.jpg)

            int number;

            do
            {
                Console.WriteLine("Iveskite bet koki skaiciu: ");
                number = int.Parse(Console.ReadLine());

            } while (number % 9 != 0);

            Console.WriteLine($"{number} yra skaicius kuris dalinasi is 9");
        }
    }
}