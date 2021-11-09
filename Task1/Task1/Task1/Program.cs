using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Ticket
    {
        public string Movie_Name { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Poster { get; set; }
        public MyDataTime Time { get; set; }

    }
    class MyDataTime
    {
        public DateTime Date { get; set; }
        public DateTime SellDate { get; set; }
        public TimeSpan Time { get; set; }
    }

}
