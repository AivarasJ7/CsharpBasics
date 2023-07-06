namespace single_operand_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int++ tas pats i = i + 1
            int number = 5;
            //senas budas arba standartinis budas
            number = number + 1;
            // naujesnis budas
            number++;
            // arba 
            ++number;

            Console.WriteLine(number++); // metodas pirma panaudos reiksme ir tik tada prides
            Console.WriteLine(++number); // pirma prides ir tik tada panaudos reiksme

            // i-- 
            // senas budas arba standartinis
            number = number - 1;
            // arba
            number--;
            // arba
            --number;

            Console.WriteLine(number--);
            Console.WriteLine(--number);

            // -i | pakeis i neigiama
            number = -number;

            // ! paneigimas
            bool isStudent = true;
            isStudent = !isStudent;
        }
    }
}