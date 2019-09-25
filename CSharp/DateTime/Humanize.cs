using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var d = new DateTime(2014, 1, 15);
		var d2 = new DateTime(2015, 7, 15);
		var d3 = new DateTime(2015, 8, 25, 8, 0, 0);
		var d4 = new DateTime(2015, 8, 24);
		var agora = new DateTime(2015, 8, 25, 0, 0, 0);
		WriteLine((d - agora).RelativeTime());
		WriteLine((d2 - agora).RelativeTime());
		WriteLine((d3 - agora).RelativeTime());
		WriteLine((d4 - agora).RelativeTime());
	}
}

public static class RelativeTimeExtensions {
	public static String RelativeTime(this TimeSpan ts) {
		const int second = 1;
		const int minute = 60 * second;
		const int hour = 60 * minute;
		const int day = 24 * hour;
		const int month = 30 * day;
		double delta = Math.Abs(ts.TotalSeconds);
		//melhor se escrever só "Agora há pouco"
		if (delta < 1 * minute) return "Há " + (ts.Seconds == 1 ? "um segundo" : ts.Seconds + " segundos");
		if (delta < 2 * minute) return "Há um minuto";
		if (delta < 45 * minute) return "Há " + ts.Minutes + " minutos";
		if (delta < 90 * minute) return "Há uma hora";
		if (delta < 24 * hour) return "Há " + ts.Hours + " horas";
		if (delta < 48 * hour) return "ontem";
		if (delta < 30 * day) return "Há " + ts.Days + " dias";
		if (delta < 12 * month) {
			var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
			return "Há " + (months <= 1 ? "um mês" : months + " meses");
		} else {
			var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
			return "Há " + (years <= 1 ? "um ano" : years + " anos");
		}
	}
}

//https://pt.stackoverflow.com/q/82278/101
