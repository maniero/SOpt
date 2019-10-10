using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var data1 = DateTime.Now;
		var data2 = new DateTime(2015, 9, 23);
		WriteLine($"Diferença: {data1 - data2}");
		WriteLine($"Mais que 4 horas: {data1 - data2 >= new TimeSpan(4, 0, 0)}");
		WriteLine($"Mais que 4 horas (outra forma): {(data1 - data2).TotalHours >= 4}");
		WriteLine($"Mais que 4 horas (se primeira pode ser anterior): {Math.Abs((data2 - data1).TotalHours) >= 4}");
		WriteLine($"Mais que 4 horas (se primeira é anterior): {-(data2 - data1).TotalHours >= 4}");
	}
}

//https://pt.stackoverflow.com/q/88493/101
