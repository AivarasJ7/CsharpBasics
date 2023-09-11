namespace classes_inheritence
{
    public class Animal
    {
        public Animal(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        public string Name { get; }
        public string Breed { get; }

        public string GetAnimalInfo()
        {
            return $"This is {Name}, its of {Breed} breed.";
        }
    }
}
