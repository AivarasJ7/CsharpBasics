using System.Xml.Linq;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            string numInput;
            int num;

            do
            {
                Console.Write("Įveskite bet kokį skaičių: ");
                numInput = Console.ReadLine();

                if (!int.TryParse(numInput, out num))
                {
                    Console.WriteLine("Neteisingai įvestas skaičius. Įveskite iš naujo.");
                }
            } while (!int.TryParse(numInput, out num));

            Console.WriteLine(Math.Pow(num, 2));
        }
    }
}