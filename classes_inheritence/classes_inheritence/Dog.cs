namespace classes_inheritence
{
    public class Dog : Animal
    {
        public Dog(
            string name, 
            string breed, 
            bool isPoliceDog) 
            : base(
                  name, 
                  breed)
        {
            IsPoliceDog = isPoliceDog;
        }

        public bool IsPoliceDog { get; }

        public string GetWhatDogSays()
        {
            return "Woof!";
        }
    }
}
