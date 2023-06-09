using System.Data;

namespace assignment2
{
    internal class Ticket
    {
        private string movieName;
        private int cinemaRoom;
        private DateTime startTime;
        private double price;
        private int minumumAge;

        public string MovieName
        {
            get { return movieName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Movie Name can not be empty or whitespace.");
                }
                movieName = value;
            }
        }
        public int CinemaRoom
        {
            get { return cinemaRoom; }
            set
            {
                if (value < 1 || value  > 5)
                {
                    throw new ArgumentException("The cinima room must be between 1 and 5");
                }
                cinemaRoom = value;
            }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if (value.Minute != 0  && value.Minute != 30)
                {
                    throw new ArgumentException("The film need to start on the hour or on half hour");
                }
                startTime = value;
            }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int MinumumAge
        {
            get { return minumumAge; }
            set
            {
                if (value != 0 && value != 6 && value != 9 && value != 12 && value != 16)
                {
                    throw new ArgumentException("Minumum age must be one of the following: 0,6,9,12,16 ");
                }
                minumumAge = value;
            }
        }
        public Ticket(string movieName, double price)
        {
            this.MovieName = movieName;
            this.Price = price;
        }
        public bool Discount
        {
            get { return startTime.DayOfWeek == DayOfWeek.Monday || startTime.DayOfWeek == DayOfWeek.Tuesday; }
        }
      
    }
}
