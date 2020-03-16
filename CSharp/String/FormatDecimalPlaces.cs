using static System.Console;
using static System.Math;

public class Program {
	public static void Main() {
		var media = 7.743;
		var arredondado = Round(media, 2);
		var texto = $"{media:0.##}";
		WriteLine(arredondado);
		WriteLine(texto);
	}
}

//https://pt.stackoverflow.com/q/439929/101
