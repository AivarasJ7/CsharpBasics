namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            int num1 = 5;

            Console.WriteLine(num1);
            Console.WriteLine(Math.Pow(num1, 2)); // kvadratu;
            Console.WriteLine(Math.Pow(num1, 3)); // kubu
            //Galima dar taip Console.WriteLine(num1 * num1);  kvadratu
            //Galima dar taip Console.WriteLine(num1 * num1 * num1);  kubu
        }
    }
}