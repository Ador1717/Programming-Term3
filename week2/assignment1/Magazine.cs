namespace assignment1
{
    public class Magazine: TitlePrice
    {
        public DayOfWeek ReleaseDay;

        public Magazine(string title, DayOfWeek releaseDay, double price) : base(title, price)
        {
            ReleaseDay = releaseDay;
        }
        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{ReleaseDay}, {Price:.00}");
        }
    }
}
