namespace cs_klases_darbas_2
{
    public class Customer
    {
        //1.Sukurkite klasę duomenims saugoti.Customer.su dviem konstruktoriais.
        //Vienas su postal code, kitas be.

        //2.Klasė turi turėti metodą vardui, pavardei ir el paštui išvesti(grąžinti).
        //Pradėkite nuo testo.

        public Customer(
            int id, 
            string name, 
            string surname, 
            string email, 
            Gender gender, 
            string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Gender = gender;
            Address = address;
        }

        public Customer(
            int id, 
            string name, 
            string surname, 
            string email, 
            Gender gender, 
            string address, 
            string postalCode)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Gender = gender;
            Address = address;
            PostalCode = postalCode;
        }

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }

        public Gender Gender { get; }
        public string Address { get; }
        public string PostalCode { get; }

        public string GetInfo()
        {
            return $"{Name} {Surname}. Jo el.pastas yra {Email}";
        }
    }
}
