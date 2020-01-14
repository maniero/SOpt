using static System.Console;
					
public class Program {
	public static void Main() {
		Write("Digite a quantidade de Cupons: ");
		var cupons = ReadLine();
		int num6;
		num6 = int.TryParse(cupons, out num6) ? num6 : 0;
		Write(num6);
	}
}

//https://pt.stackoverflow.com/q/129203/101
