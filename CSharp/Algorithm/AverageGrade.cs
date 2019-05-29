using static System.Console;

public class Program {
	public static void Main() {
		var estudante = new Nota {
			Matricula = ReadLine(),
			Idade = int.Parse(ReadLine()),
            Prova1 = double.Parse(ReadLine()),
            Prova2 = double.Parse(ReadLine()),
            Trabalho = double.Parse(ReadLine())
		};
        estudante.MostraDadosDeNota();
	}
}
public class Nota {
	public string Matricula { get; set; }
	public string Nome { get; set; }
	public int Idade { get; set; }
	public double Prova1 { get; set; }
	public double Prova2 { get; set; }
	public double Trabalho { get; set; }
	public double Media { get => (Prova1 * 2.5 + Prova2 * 2.5 + Trabalho * 1.5) / 6.5; }

	public void MostrarMedia() => WriteLine($"Sua media foi igual a: {Media:0.00}");
	public void MostrarNotaFaltante() {
		if (Media >= 6.0) WriteLine("Passou");
		else  WriteLine($"Faltou {6.0 - Media:0.00} pontos para passar");
	}
	public void MostrarMelhorNota() {
		double nota = Prova1;
		if (Prova2 > nota) nota = Prova2;
		if (Trabalho > nota) nota = Trabalho;
		WriteLine($"Sua maior nota foi: {nota:0.00} pontos");
	}
	public void MostraDadosDeNota() {
		MostrarMedia();
		MostrarNotaFaltante();
		MostrarMelhorNota();
	}
}

//https://pt.stackoverflow.com/q/387638/101
