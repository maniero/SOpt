using static System.Console;

public class Circulo {
	public Circulo(double raio) => Raio = raio;
	public double Raio { get; }
	public double Area => 3.14159 * Raio * Raio;
	public string Imprima() => Raio + " " + Area + " ";
}

public class AppCirculo {
	static int Main() {
		Write("Digite o raio do círculo 1: ");
		if (!double.TryParse(ReadLine(), out var valor)) return 1;
		var circulo1 = new Circulo(valor);
		Write("Digite o raio do círculo 2: ");
		if (!double.TryParse(ReadLine(), out valor)) return 1;
		var circulo2 = new Circulo(valor);
		Write("Digite o raio do círculo 3: ");
		if (!double.TryParse(ReadLine(), out valor)) return 1;
		var circulo3 = new Circulo(valor);
		WriteLine(circulo1.Imprima());
		WriteLine(circulo2.Imprima());
		WriteLine(circulo3.Imprima());
		return 0;
	}
}

//https://pt.stackoverflow.com/q/413055/101
