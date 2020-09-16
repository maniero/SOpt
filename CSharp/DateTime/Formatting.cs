using System.Globalization;

public class Program {
	public static void Main() {
		var minhaCultura = new CultureInfo("pt-BR"); 
		minhaCultura.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
		minhaCultura.DateTimeFormat.ShortTimePattern = "HH:mm";
		minhaCultura.NumberFormat.NumberDecimalDigits = 2;
		minhaCultura.NumberFormat.NumberGroupSeparator = "_";
		minhaCultura.NumberFormat.NumberDecimalSeparator = ",";
		System.Console.WriteLine(string.Format(minhaCultura, "{0:N}", 43239.11));
	}
}

//https://pt.stackoverflow.com/q/44957/101
