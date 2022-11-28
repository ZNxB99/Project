public class Time{
    public Time time = Time.Now;
    public static DateOnly dateOnly;
    public static TimeOnly timeOnly;
    public static double GetTimetodoble(){
        timeOnly = TimeOnly.FromDateTime(Time.Now);
        double hour = timeOnly.Hour;
        double minute = timeOnly.Minute;
        return hour+(minute/100);
    }
    public static DateOnly GetDate(){
        dateOnly = DateOnly.FromDateTime(Time.Now);
        return dateOnly;
    }
    public static TimeOnly GetTime(){
        timeOnly = TimeOnly.FromDateTime(Time.Now);
        return timeOnly;
    }
}