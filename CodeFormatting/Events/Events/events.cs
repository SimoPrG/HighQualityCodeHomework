using System;
using System.Text;

internal class Events : IComparable
{
    public DateTime Date { get; private set; }

    public string Title { get; private set; }

    public string Location { get; private set; }

    public Events(DateTime date, String title, String location)
    {
        this.Date = date;
        this.Title = title;
        this.Location = location;
    }

    public int CompareTo(object obj)
    {
        Events other = obj as Events;
        int byDate = this.Date.CompareTo(other.Date);
        int byTitle = this.Title.CompareTo(other.Title);

        int byLocation = this.Location.CompareTo(other.Location);
        if (byDate == 0)
        {
            if (byTitle == 0)
            {
                return byLocation;
            }
            else
            {
                return byTitle;
            }
        }
        else
        {
            return byDate;            
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(Date.ToString("yyyy-MM-ddTHH:mm:ss"));

        toString.Append(" | " + Title);
        if (Location != null && Location != "")
        {
            toString.Append(" | " + Location);
        }

        return toString.ToString();
    }
}