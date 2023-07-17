namespace csharp19_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Užduotis 2: Sukurkite studentų pažymėjimų numerių rinkinį naudodami HashSet. 
            //Panaudokite Contains metodą, kad patikrintumėte, ar skaičius yra jūsų sukurtame HashSet. 
            //Programa turi išvesti tekstą, kuris nurodo, kad studentas, jeigu jis yra rinkinyje gali patekti į universiteto patalpas.

            HashSet<int> studentDocumentNumbers = new HashSet<int>()
            {
                2694, 1244, 1445
            };

            if (studentDocumentNumbers.Contains(1244))
            {
                Console.WriteLine("Studentas gali patekti i universiteto patalpas");
            }
            else
            {
                Console.WriteLine("Studentas negali patekti i universiteto patalpas");
            }
        }
    }
}