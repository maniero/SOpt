using System;

public class Appointment {
    public string Content { get; set; }
    private bool validDate = false;
    private DateTime date;
    public string Date {
        get { return Date.ToString(); }
        set {
            if (DateTime.TryParse(value, out var dateValue)) {
                date = dateValue;
                validDate = true;
            }
        }
    }
}

//https://pt.stackoverflow.com/q/542999/101
