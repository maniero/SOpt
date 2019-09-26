using System;
using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		var dtSolicitacao = "27/08/215 09:06:33";
		var horario = DateTime.Parse(dtSolicitacao, CultureInfo.GetCultureInfo("pt-BR")).TimeOfDay;
		WriteLine(horario);
		DateTime horario2;
		if (DateTime.TryParse(dtSolicitacao, CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None, out horario2)) {
			WriteLine(horario2.TimeOfDay);
		} else {
			WriteLine("deu erro");
		}
	}
}

//https://pt.stackoverflow.com/q/82838/101
