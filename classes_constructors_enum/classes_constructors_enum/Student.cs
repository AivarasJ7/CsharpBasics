namespace classes_constructors_enum
{
    public class Student
    {
        public Student(
            string name, 
            string surname, 
            Adress adress, 
            Gender gender)
        {
            Name = name;
            Surname = surname;
            Adress = adress;
            Gender = gender;
        }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void ChangeAge(int newAge)
        {
            Age = newAge;
        }

        public string Name { get; }
        public int Age { get; private set; } // pasikeisti viduj 
        public string Surname { get; }
        public Adress Adress { get; }
        public Gender Gender { get; }
    }
}
