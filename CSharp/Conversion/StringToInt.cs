using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(BtnSoma_Click(ReadLine(), ReadLine()));
	}
    private static string BtnSoma_Click(string txtNum1, string txtNum2) {
        if (!int.TryParse(txtNum1, out var valor1) || !int.TryParse(txtNum2, out var valor2)) {
            WriteLine("Pelo menos um dos valores é inválido");
            return null;
        }
        return (valor1 + valor2).ToString(); 
    }
}

//https://pt.stackoverflow.com/q/350190/101
