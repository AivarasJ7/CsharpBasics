namespace polymorphism.Dynamic
{
    public class Manager : Employee
    {
        public Manager(string name, string description) : base(name, description)
        {
        }

        public override string GetRoleDescription()
        {
            return $"Role is manager klases {Name}. {Description}.";
        }
    }
}
