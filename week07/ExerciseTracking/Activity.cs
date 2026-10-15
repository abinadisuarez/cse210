using System;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string name = GetType().Name;
        string date = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        return $"{date} {name} ({_minutes} min): " +
               $"Distance {GetDistance().ToString("F1", CultureInfo.InvariantCulture)} miles, " +
               $"Speed: {GetSpeed().ToString("F1", CultureInfo.InvariantCulture)} mph, " +
               $"Pace: {GetPace().ToString("F1", CultureInfo.InvariantCulture)} min per mile";
    }
}