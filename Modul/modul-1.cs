// 2 Variant
public enum DaysOfWeek {
    Monday, 
    Tuesday,
    Wednesday,
    Thuersday,
    Friday,
    Saturday,
    Sunday

}


public class CalendarEvent {
    private string EventName {get; set;}
    private DaysOfWeek EventDay {get; set;}

    public CalendarEvent(string evName, DaysOfWeek evDay) {
        EventName = evName;
        EventDay = evDay;
    }

    public void PrintEventDetails() {
        Console.WriteLine($"Подія {EventName} відбудеться в день {EventDay}");
    }

}


 class Program {
    static void Main() {
        CalendarEvent event1 = new CalendarEvent("Birthday party", DaysOfWeek.Sunday);
        event1.PrintEventDetails();
    }
}
