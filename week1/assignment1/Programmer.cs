namespace assignment1
{
    internal class Programmer
    {
        public string Name;
        public specialties Specialties;

        public Programmer (string name, specialties specialties)
        {
            Name = name;
            Specialties = specialties;
        }
        public Programmer(string name) : this(name, specialties.Unknown)
        {
        }
        public void Print()
        {
            Console.WriteLine("Name: "+ Name + ", Specialty: " + Specialties);
        }
    }
}
