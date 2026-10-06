using System;
using System.Collections.Generic;

public class ActivityLog
{
    private List<Activity> _completedActivities = new List<Activity>();

    public void Record(Activity activity)
    {
        _completedActivities.Add(activity);
    }

    public int GetCount()
    {
        return _completedActivities.Count;
    }

    public void DisplaySummary()
    {
        Console.WriteLine("Session summary:");

        int totalSeconds = 0;

        foreach (Activity activity in _completedActivities)
        {
            Console.WriteLine($"{activity.GetName()} - {activity.GetDuration()} seconds");
            totalSeconds += activity.GetDuration();
        }

        Console.WriteLine($"\nYou completed {GetCount()} activities for a total of {totalSeconds} seconds.");
    }
}