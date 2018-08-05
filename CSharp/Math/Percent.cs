using static System.Console;
	
public class Program {
	public static void Main() {
		var larguraText = "2.00";
		var alturaText = "1.00";
		var percText = "30";
		var total = 0.0;
		double largura;
		double altura;
		double perc;
		if (double.TryParse(larguraText, out largura) && double.TryParse(alturaText, out altura) && double.TryParse(percText, out perc)) {
			total = largura * altura * (perc / 100);
		}
		var totalText = total.ToString(); //só para fins didáticos do exemplo
		WriteLine(totalText);
	}
}

//https://pt.stackoverflow.com/q/320182/101
