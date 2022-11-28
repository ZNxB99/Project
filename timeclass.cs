public class DateTime{
    private DateTime datetime = DateTime.Now;
    private static DateOnly dateOnly;
    private static TimeOnly timeOnly;
    public static double GetTimetodoble(){
        timeOnly = TimeOnly.FromDateTime(DateTime.Now);
        double hour = timeOnly.Hour;
        double minute = timeOnly.Minute;
        return hour+(minute/100);
    }
    public static DateOnly GetDate(){
        dateOnly = DateOnly.FromDateTime(DateTime.Now);
        return dateOnly;
    }
    public static TimeOnly GetTime(){
        timeOnly = TimeOnly.FromDateTime(DateTime.Now);
        return timeOnly;
    }
}