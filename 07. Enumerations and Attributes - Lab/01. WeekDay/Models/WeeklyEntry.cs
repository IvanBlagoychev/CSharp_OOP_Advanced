using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay => this.weekDay;
    public string Notes { get; set; }

    public int CompareTo(WeeklyEntry other)
    {
        if (this.WeekDay.CompareTo(other.WeekDay) != 0)
        {
            return this.WeekDay.CompareTo(other.WeekDay);
        }
        return this.Notes.CompareTo(other.Notes);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}