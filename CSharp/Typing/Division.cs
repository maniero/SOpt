using static System.Console;
using static System.Math;

public class Program {
	public static void Main() {
		var contador = 63;
		decimal arrendondamento = contador / 50M;
		WriteLine(arrendondamento);
		WriteLine(Ceiling(arrendondamento));
	}
}

//https://pt.stackoverflow.com/q/380046/101
