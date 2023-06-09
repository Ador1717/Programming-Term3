using System.Diagnostics;

namespace assignment1
{
    public class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set;  }

        public Magazine(string title, DayOfWeek releaseDay, double price, int count) : base(title, price, count)
        {
            ReleaseDay = releaseDay;
        }
        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{ReleaseDay}, {Price:.00} ({Count}x)");
        }
    }
}
