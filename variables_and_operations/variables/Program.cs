namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single line comment


            /* Multi 
            *  Line 
            *  comment
            * 
            * 
            */

            //VARIABLES 
            // int - sveikasis skaičius
            int age = 18;
            int unassignedValue; // by default bus 0

            age = age + 1;
            age++;
            age += 4;

            //int 3studentAge = 20; Kintamasis negali prasideti skaiciumi
                Console.WriteLine(age);

            //float, double and decimal 
            float testFloat = 20.02f;
            double testDouble = 20.02;
            decimal testDecimal = 20.02m;

            Console.WriteLine($"testFloat value: {testFloat}");
            Console.WriteLine($"testDouble value: {testDouble}");
            Console.WriteLine($"testDecimal value: {testDecimal}");

            // char is symbol type

            char symbol1 = 's';
            char symbol2 = '1';
            char symbol3 = '#';

            //cw code snippet for Console.WriteLine()
            Console.WriteLine($"symbol1 value: {symbol1}");
            Console.WriteLine($"symbol2 value: {symbol2}");
            Console.WriteLine($"symbol3 value: {symbol3}");

            //string is a text type

            string name1 = "Jonas";
            string name2 = "Petras";
            
            Console.WriteLine($"name1 = {name1}, name2 = {name2}");



        }
    }
}