using System;
using System.Windows.Forms;



namespace WindowsFormsApp5
{

    public class WorkDay : IComparable
    {
        public DateTime DateAndTime { get; set; }

        public double Hours { get; set; }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = int.Parse(string.Concat(DateAndTime.Year, DateAndTime.Month, DateAndTime.Day)); }
        }


        public override int GetHashCode()
        {
            return Id;
        }

        public int CompareTo(object obj)
        {
            if ((obj as WorkDay).DateAndTime.Date == this.DateAndTime.Date)
            {
                return 0;
            }
            else if ((obj as WorkDay).DateAndTime.Date > this.DateAndTime.Date)
            {
                return -1;
            }
            else return 1;
        }

        public override string ToString()
        {
            return $"You've worked {Hours} hours on {DateAndTime.Date.ToShortDateString()}.";
        }
    }
}