namespace Blazorise.ExComponents;

public static class Extensions
{
    public static bool IsToday(this DateTime date) => DateTime.Now.DayOfYear == date.DayOfYear;
}