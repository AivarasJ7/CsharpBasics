namespace polymorphism.Dynamic
{
    public abstract class Employee
    {
        public Employee(string name, string description)
        {
            Name = name;
            Description = description;
        }

        protected string Name { get; }
        protected string Description { get; }

        public abstract string GetRoleDescription();
    }
}
