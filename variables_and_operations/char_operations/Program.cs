namespace char_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = 'a';
            char symbol2 = 'b';
            char symbol3 = 'c';

            string connectedSymbol1 = $"{symbol1}{symbol2}{symbol3}";
            string connectedSymbols2 = 
                symbol1.ToString() + 
                symbol2.ToString() + 
                symbol3.ToString();

            string connectedSymbols3 = string.Format(
                "{0}{1}{2}", 
                symbol1, 
                symbol2, 
                symbol3
            );
        }
    }
}