namespace cs_klases_darbas_2
{
    public class CustomerListConverter
    {
        public List<Customer> Convert(List<string> lines)
        {
            List<Customer> customers = new List<Customer>();

            foreach (string line in lines)
            {
                if(line.Count(s => s == ',') != 5)
                {
                    continue;
                }
                customers.Add(CreateCustomer(line));
            }

            return customers;
        }

        private Customer CreateCustomer(string line)
        {
            // 208
            // Alexis Mohun
            // amohun5r@over-blog.com
            // Male
            // Room 1557

            string[] values = line.Split(',');
            int id = int.Parse(values[0]);
            string name = values[1].Trim().Split(' ')[0].Trim();
            string surname = values[1].Trim().Split(' ')[1].Trim();
            string email = values[2].Trim();
            Gender gender = ResolveGender(values[3]);
            string adress = values[4].Trim();
            string postCode = values[5].Trim();

            if (string.IsNullOrEmpty(postCode))
            {
                return new Customer(
                id,
                name,
                surname,
                email,
                gender,
                adress
                );
            }

            return new Customer(
                id,
                name,
                surname,
                email,
                gender,
                adress,
                postCode
                );
        }

        private Gender ResolveGender(string gender)
        {
            switch (gender.ToLower())
            {
                case "male":
                    return Gender.Male;

                case "female":
                    return Gender.Female;

                case "bigender":
                    return Gender.Bigender;

                case "polygender":
                    return Gender.Polygender;

                case "genderqueer":
                    return Gender.Genderqueer;

               case "genderfluid":
                    return Gender.Genderfluid;

                case "non-binary":
                    return Gender.Nonbinary;

                case "agender":
                    return Gender.Agender;

                default:
                    throw new NotSupportedException("Gender was not found");
            }
        }
    }
}
