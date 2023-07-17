namespace csharp19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 1: Sukurti HashSet, kuris saugo sveikųjų skaičių seką. 
            // Pridėti 5 skaičius ir ištrinti vieną.

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i <= 5; i++)
            {
                numbers.Add(i);
            }

            numbers.Remove(3);
        }
    }
}