namespace Classes_inheritence_with_protected
{
    public class Manager : Employee
    {
        public Manager(string name, string description) : base(name, description)
        {

        }

        // dynaminis polimorfizmas
        public override string GetRoleDescription()
        {
            return $"Roles aprasymas is Manager klases. {Name}. {Description}.";
        }
    }
}
