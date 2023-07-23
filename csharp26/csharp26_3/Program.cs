namespace csharp26_3
{
    public class Program
    {
        public static void Main()
        {
            // Užduotis 3: Sukurti žodyno (angl. dictionary) pagrindu supaprastintą registracijos sistemą
            // Metodas: Sukurkite klasę su metodais, leidžiančiais pridėti vartotoją, patikrinti ar vartotojas egzistuoja ir atlikti prisijungimą. 
            // Pabandykite sukurti testus.

            RegistrationSystem registrationSystem = new RegistrationSystem();

            registrationSystem.AddUser("user1", "slaptazodis1");
            registrationSystem.AddUser("user2", "slaptazodis2");
            registrationSystem.AddUser("user3", "slaptazodis3");
            registrationSystem.AddUser("user1", "test");

            string username = "user1";
            string password = "slaptazodis1";

            if (registrationSystem.CheckIfUserExists(username))
            {
                registrationSystem.Login(username, password);
            }
            else
            {
                Console.WriteLine($"Vartotojas: {username} nerastas");
            }

            username = "test";
            password = "slaptazodis2";
            if (registrationSystem.CheckIfUserExists(username))
            {
                registrationSystem.Login(username, password);
            }
            else
            {
                Console.WriteLine($"Vartotojas: {username} nerastas");
            }
        }
    }
}