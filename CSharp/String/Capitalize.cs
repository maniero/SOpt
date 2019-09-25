using static System.Console;
					
public class Program {
	public static void Main() {
		var texto = "stack exchange";
		var upper = texto.Length > 1 ? char.ToUpper(texto[0]) + texto.Substring(1) : texto.ToUpper();
		WriteLine(upper);
	}
}

//https://pt.stackoverflow.com/q/82141/101
