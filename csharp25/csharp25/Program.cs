using System;

namespace csharp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Susikurkite šiuos kintamuosius iškart su reikšmėmis:
            // Vardas;
            // Pavardė;
            // Amžius.
            // Pasirašykite metodą kuris leistų vartotojui pakeisti šių kintamųjų reikšmes ir tai sugebėtų atnaujinti main’e.
            //Išveskite kintamųjų reikšmes main metode prieš kviečiant papildomą metodą ir po papildomo metodo kvietimo.

            string name = "Jonas";
            string surname = "Jonaitis";
            int age = 35;

            Console.WriteLine($"Vardas pries pakeitima: {name}");
            Console.WriteLine($"Pavarde pries pakeitima: {surname}");
            Console.WriteLine($"Amzius pries pakeitima: {age}");

            ChangePersonInfo(ref name, ref surname, ref age);

            Console.WriteLine($"Vardas po pakeitimo: {name} \nPavarde po pakeitimo: {surname} \nMetai po pakeitimo: {age}");
        }

        private static void ChangePersonInfo(ref string name, ref string surname, ref int age)
        {
            Console.WriteLine("Iveskite pakeitima vardui:");
            name = Console.ReadLine();

            Console.WriteLine("Iveskite pakeitima pavardei:");
            surname = Console.ReadLine();

            Console.WriteLine("Iveskite pakeitima amziui:");
            age = int.Parse(Console.ReadLine());
        }
    }
}