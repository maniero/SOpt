using static System.Console;
using System;

public class Program {
	public static void Main() {
		WriteLine(TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")));
        WriteLine("{0} - ", TimeZoneInfo.Local);
        WriteLine("{0} - ", TimeZoneInfo.Utc);
		foreach (var zone in TimeZoneInfo.GetSystemTimeZones()) {
			Write("{0} - ", zone.Id);
            Write("{0} - ", zone.BaseUtcOffset);
            Write("{0} - ", zone.DisplayName);
            Write("{0} - ", zone.DaylightName);
			WriteLine("{0} - ", zone.SupportsDaylightSavingTime);
		}
	}
}

//https://pt.stackoverflow.com/q/46488/101
