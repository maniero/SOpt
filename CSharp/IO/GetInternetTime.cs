InternetTime.SNTPClient sntp = new InternetTime.SNTPClient("ntp1.ja.net");
sntp.Connect(false); // true to update local client clock
DateTime dt = sntp.DestinationTimestamp.AddMilliseconds(sntp.LocalClockOffset);
var timeStampNow = dt.ToString("dd/MM/yyyy HH:mm:ss.fff");

//https://pt.stackoverflow.com/q/155457/101
