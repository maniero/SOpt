using System;

public class Appointment {
    public string Content { get; set; }
    private bool validDate = false;
    public DateTime Date { get; set; }
    public void SetDate(string date) {
        if (DateTime.TryParse(date, out var dateValue)) {
            Date = dateValue;
            validDate = true;
        }
    }
}

//https://pt.stackoverflow.com/q/542999/101
