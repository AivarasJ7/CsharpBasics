namespace string_methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string text = "Labas rytas";
            //string newText = text.Substring(0, 2); // nuo kurio ir kiek imsim raidziu  
            //string newText1 = text.Substring(text.IndexOf('r')); // nereiktu skaiciuot   

            string text = "Labas rytelis Jonai!";

            int position = text.IndexOf('r');

            text = text.Substring(
                position, 
                text.IndexOf(" ", position) - position
                );
        }
    }
}