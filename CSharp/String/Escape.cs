using static System.Console;

public class Program {
	public static void Main() {
		var texto = @"É necessário Cadastrar o(s) seguinte(s) Parâmetro(s):SENHA_FTP\r\n";
		WriteLine(texto.Replace(@"\", @"\\"));
	}
}

//https://pt.stackoverflow.com/q/260390/101
