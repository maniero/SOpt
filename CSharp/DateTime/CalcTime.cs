using System;
					
public class Program {
	public static void Main() {
	    var TempoOtimista = new TimeSpan(2, 15, 40);
		var TempoProvavel = new TimeSpan(2, 14, 10);
		var TempoPessimista = new TimeSpan(2, 16, 40);
		var TempoRevisado = new TimeSpan();
	    TempoRevisado = new TimeSpan(0, 0, (int)(TempoOtimista + TempoProvavel + TempoPessimista).TotalSeconds / 3);
		Console.WriteLine(TempoRevisado);
	}
}

//https://pt.stackoverflow.com/q/92213/101
