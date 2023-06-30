namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Susikurkite sveikojo skaičiaus kintamąjį su dviženklio skaičiaus reikšme. 

            int number = 25;
            int tensDigit = number / 10;                            //25 / 10 = 2.5 = 2 (pirmas skaitmuo)
            int onesDigit = number % 10;                            //25 % 10 = 5 (antras skaitmuo)
            int product = tensDigit * onesDigit;                    //logika kuri paema pirma skaitmeni ir padaugina is antro

            Console.WriteLine($"Skaičius: {number}");
            Console.WriteLine($"Skaitmenų sandaugą: {product}");    //Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
        }
    }
}