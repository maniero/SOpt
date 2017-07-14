using static System.Console;

public class Program {
	public static void Main() {
		int number;
		do {
			WriteLine("Enter a number between 1111 and 9999: ");
			number = int.Parse(ReadLine()); //isto dá erro se digitar algo errado, deveria usar TryParse()
		} while (number < 1111 || number > 9999);
		var texto = "";
		while (number > 0) {
			texto = number % 10 + "\n" + texto; //o uso de \n pode não ser o ideal sempre
			number /= 10;
		}
		WriteLine(texto);
	}
}

//https://pt.stackoverflow.com/q/220446/101
