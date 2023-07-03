namespace logical_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //veiksmai su palyginimu
            Console.WriteLine(5 < 6);

            bool result1 = 10 == 10; 

            Console.WriteLine(result1);

            int age1 = 10;
            int age2 = 15;

            Console.WriteLine(age1 < age2);

            string password1 = "Qwerty123";
            string password2 = "qwerty123";

            Console.WriteLine(password1 == password2);
            Console.WriteLine(password1 != password2);
            Console.WriteLine(password1.Length >= password2.Length);

            int age = 20;

            //patikrite ar amzius yra didesnis uz 20;
            Console.WriteLine(age > 20);

            //patikrite ar amzius yra didesnis arba lygus uz 20;
            Console.WriteLine(age >= 20);

            // [5, 10]
            // ] - imtinai
            // ) - ne imtinai

            // [5, 10) -- intervalas
            // AND &&
            // OR ||

            int x = 6;

            Console.WriteLine(x >= 5 && x < 10); // AND atveju kai visi true, bendras true;

            x = 100;

            Console.WriteLine(x >= 5 || x < 10); // OR atveju bent vienas yra true, visi true;

            char symbol1 = 'a';

            Console.WriteLine(symbol1 == 'A' || symbol1 == 'a');

            string password = "qwerty";

            Console.WriteLine(
                password == "qwerty" ||
                password == "QWERTY" ||
                password == "Qwerty" ||
                password == "QwErty"
            );
        }
    }
}