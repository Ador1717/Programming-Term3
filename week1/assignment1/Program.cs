namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Programmer p1 = new Programmer("Peter", specialties.Csharp);
            Programmer p2 = new Programmer("Kevin", specialties.Java);
            Programmer p3 = new Programmer("John", specialties.Csharp);
            Programmer p4 = new Programmer("Susan", specialties.Java);
            Programmer p5 = new Programmer("Emma", specialties.Unknown);

            Team t = new Team();
            t.AddProgrammer(p1);
            t.AddProgrammer(p2);
            t.AddProgrammer(p3);
            t.AddProgrammer(p4);
            t.AddProgrammer(p5);

            t .PrintAllTeamMembers();
        }
    }
}
