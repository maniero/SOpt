using static System.Console;

public class Test {
	public static void Main() {
		var choice = (char)Read();
		if (ReadLine() == "s") Write("ok");
	}
}

//https://pt.quora.com/Na-entrada-de-dados-da-linguagem-C-a-limpeza-de-buffer-n%C3%A3o-%C3%A9-necess%C3%A1ria-como-no-caso-da-C-e-C-O-que-explica-isso
