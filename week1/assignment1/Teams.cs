namespace assignment1
{
    internal class Team
    {
        public List <Programmer> Teams ;

        public Team()
        {
           Teams = new List <Programmer>();
        }
        public void AddProgrammer(Programmer p)
        {
            Teams.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer programmer in Teams)
            {
                programmer.Print();
            }
        }
    }
}
