namespace classes_inheritence
{
    public class Cat : Animal
    {
        public Cat(string name, string breed) : base(name, breed)
        {
        }

        public string GetWhatCatSays()
        {
            return "Meow!";
        }
    }
}
