namespace assignment2
{
    internal class Customer
    {
        private string name;
        private DateTime birth;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be empty or whitespace.");
                }
                name = value;
            }
        }
        public DateTime Birth
        {
            get { return birth; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Date of birth can not be in the past");
                }
                birth = value.Date;
            }
        }

        public Customer(string name, DateTime birth)
        {
            this.Name = name;
            this.Birth = birth;
        }
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - Birth.Year  ;
                if (DateTime.Today < Birth.AddYears(age))
                {
                    age--;
                }
                return age ;
            }
        }
        public bool Discount
        {
            get
            {
                return (Age >= 60); 
            }
        }
    }
}

