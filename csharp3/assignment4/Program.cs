namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Išveskite į ekraną šių veiksmų atsakymus:
                -1 + 4 * 6
                (35 + 5) % 7
                14 + -4 * 6 / 11
                2 + 15 / 6 * 1 - 7 % 2
             */

            int result1 = -1 + 4 * 6;
            decimal result2 = (35 + 5) % 7;
            decimal result3 = 14 + -4 * 6 / 11.0m;
            decimal result4 = 2 + 15 / 6.0m * 1 - 7 % 2;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}