using System;

public class Program {
	public static void Main() {
		var dataFechamento = new DateTime(2017, 12, 25);
		dataFechamento = isSunday(dataFechamento);
		if (true) {
			dataFechamento = dataFechamento.AddDays(-1);
			dataFechamento = isSunday(dataFechamento);
		}
		Console.WriteLine(dataFechamento);
		DateTime isSunday(DateTime date) => date.DayOfWeek == DayOfWeek.Sunday ? date.AddDays(-1) : date;
	}
}

//https://pt.stackoverflow.com/q/262559/101
