using System;

namespace csharpextra1_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 5.Parašykite programą, kuri patikrina, ar vartotojo įvestas skaičius yra palindromas(skaitytas iš abiejų pusių vienodai).
            // Jei skaičius yra palindromas, išveskite: "Skaičius {skaičius} yra palindromas." Jei ne: "Skaičius {skaičius} nėra palindromas.
            // " Programa turi veikti su skaičiais ir tekstais, pvz.:
            // Įvestas skaičius: 121
            // Skaičius 121 yra palindromas.
            // Įvestas tekstas: "abccba"
            // Tekstas "abccba" yra palindromas.

            Console.Write("Iveskite skaiciu arba teksta: ");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindrome(input);

            if (isPalindrome)
            {
                Console.WriteLine($"({input}) yra palindromas.");
            }
            else
            {
                Console.WriteLine($"({input}) nera palindromas.");
            }
        }

        public static bool IsPalindrome(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            return input == reversed;
        }
    }
}