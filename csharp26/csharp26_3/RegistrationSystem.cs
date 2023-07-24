namespace csharp26_3
{
    public class RegistrationSystem
    {
        public Dictionary<string, string> userStorage;

        public RegistrationSystem()
        {
            userStorage = new Dictionary<string, string>();
        }

        public void AddUser(string username, string password)
        {
            if (!userStorage.ContainsKey(username))
            {
                userStorage.Add(username, password);
                Console.WriteLine($"Vartotojas - {username} pridetas sekmingai");
            }
            else
            {
                Console.WriteLine($"{username} - Toks vartotojas jau egzistuoja");
            }
        }

        public bool CheckIfUserExists(string username)
        {
            return userStorage.ContainsKey(username);
        }

        public bool Login(string username, string password)
        {
            if (userStorage.TryGetValue(username, out string storedPassword))
            {
                if (storedPassword == password)
                {
                    Console.WriteLine("Prisijungimas sekmingas");
                    return true;
                }
                else
                {
                    Console.WriteLine("Neteisingas slaptazodis");
                }
            }
            else
            {
                Console.WriteLine($"{username} - Vartotojas nerastas");
            }

            return false;
        }
    }
}
