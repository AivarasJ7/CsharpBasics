namespace CSharpKlases10
{
    public class Laptop : Computer
    {
        // Tada sukurkite paveldėtą Laptop klasę su papildoma savybe BatteryLife ir papildomu metodu PrintLaptopInfo(),
        // kuris išveda informaciją apie nešiojamąjį kompiuterį. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Laptop(string brand, string model, int batteryLife) : base(brand, model)
        {
            BatteryLife = batteryLife;
        }

        public int BatteryLife { get; }

        public void PrintLaptopInfo()
        {
            Console.WriteLine($"Prekes zenklas: {Brand}, Modelis: {Model}, baterijos veikimo laikas: {BatteryLife}.");
        }
    }
}
