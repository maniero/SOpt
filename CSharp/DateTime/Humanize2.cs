var dtNow = DateTime.Now;
var dtYesterday = DateTime.Now.AddDays(-435.0);
var ts = dtNow.Subtract(dtYesterday);
var years = ts.Days / 365; //no leap year accounting
var months = (ts.Days % 365) / 30; //naive guess at month size
var weeks = ((ts.Days % 365) % 30) / 7;
var days = (((ts.Days % 365) % 30) % 7);
var sb = new StringBuilder("Há ");
if(years > 0) sb.Append(years.ToString() + " anos, ");
if(months > 0) sb.Append(months.ToString() + " meses, ");
if(weeks > 0) sb.Append(weeks.ToString() + " semanas, ");
if(days > 0) sb.Append(days.ToString() + " dias.");
var FormattedTimeSpan = sb.ToString();

//https://pt.stackoverflow.com/q/82278/101
