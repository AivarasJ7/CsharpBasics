namespace Classes_inheritence_with_protected
{
    public class Employee
    {
        public Employee(string name, string description) 
        {
            Name = name;
            Description = description;
        }
        
        //protected tik vaikines mato
        protected string Name { get; }
        protected string Description { get; }

        public virtual string GetRoleDescription()
        {
            return $"Roles aprasymas is Employee. {Name}. {Description}";
        }
    }
}
